using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace FilesOrgenizer
{


    public partial class Form1 : Form
    {
        // static object _locker = new object();
        static long counter;
        BackgroundWorker bw = new BackgroundWorker();
        BackgroundWorker bw2 = new BackgroundWorker();
        private string BACKUP_PATH = "duplicates_backup_";
        static readonly string[] monthsNames = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        static readonly List<string> Extensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };



        public Form1()
        {
            bw.DoWork += bw_DoWork;
            bw2.DoWork += bw2_DoWork;
            InitializeComponent();
        }

        void bw2_DoWork(object sender, DoWorkEventArgs e)
        {
            bool folderAsNames = radioButtonMonthNames.Checked;


            var folderPath = txtFolderPath.Text;
            var target = txtTargetFolder.Text;


            if (!Directory.Exists(target))
            {
                Directory.CreateDirectory(target);
            }

            string[] filePaths = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);


            txtLog.Invoke(new Action(() =>
            {
                txtLog.AppendText(filePaths.Length + " files found" + Environment.NewLine);
            }));

            System.Threading.Tasks.Parallel.ForEach(filePaths, fileSource =>
            {
                try
                {
                    // Console.WriteLine(fileSource);

                    var fi = new FileInfo(fileSource);

                    int year = fi.LastWriteTime.Year;
                    int month = fi.LastWriteTime.Month;

                    if (Extensions.Contains(fi.Extension))
                    {
                        try
                        {
                            var takenDate = GetDateTaken(fileSource);
                            year = takenDate.Year;
                            month = takenDate.Month;
                        }
                        catch (Exception ex)
                        {
                            //Console.WriteLine("error with: " + fileSource + " " + ex.Message);
                        }
                    }
                    var folderTarget = target + "\\" + year.ToString();

                    if (!Directory.Exists(folderTarget))
                    {
                        Directory.CreateDirectory(folderTarget);
                    }

                    var fileTarget = folderAsNames ?
                        target + "\\" + year.ToString() + "\\" + monthsNames[month - 1] :
                        target + "\\" + year.ToString() + "\\" + month.ToString();

                    if (!Directory.Exists(fileTarget))
                    {
                        Directory.CreateDirectory(fileTarget);
                    }


                    string moveToPath = fileTarget + "\\" + fi.Name;
                    if (File.Exists(moveToPath))
                    {
                        lock (lockObject)
                        {
                            moveToPath = GetNextFileName(moveToPath);
                        }
                    }

                    try
                    {
                        File.Move(fileSource, moveToPath);

                        txtLog.Invoke(new Action(() =>
                        {
                            txtLog.AppendText(fileSource + " --> " + moveToPath + Environment.NewLine);
                        }));

                    }
                    catch (Exception)
                    {
                        txtLog.Invoke(new Action(() =>
                            {
                                txtLog.AppendText("Error moving " + fileSource + " to " + moveToPath + Environment.NewLine);
                            }));
                    }

                    var p = Path.GetDirectoryName(fileSource);
                    if (IsDirectoryEmpty(p))
                    {
                        try
                        {
                            Directory.Delete(p);
                        }
                        catch (Exception ex)
                        {
                            txtLog.Invoke(new Action(() =>
                            {
                                txtLog.AppendText("Cannot delete folder " + p + Environment.NewLine);
                            }));
                        }
                    }


                    //if (!File.Exists(fileTarget + "\\" + fi.Name))
                    //{
                    //    File.Move(fileSource, fileTarget + "\\" + fi.Name);


                    //    var p = Path.GetDirectoryName(fileSource);
                    //    if (IsDirectoryEmpty(p))
                    //    {
                    //        try
                    //        {
                    //            Directory.Delete(p);
                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            txtLog.Invoke(new Action(() =>
                    //            {
                    //                txtLog.AppendText("Cannot delete folder " + p + Environment.NewLine);
                    //            }));
                    //        }
                    //    }
                    //}
                    //else
                    //{
                    //    txtLog.Invoke(new Action(() =>
                    //    {
                    //        txtLog.AppendText(fileSource + " - Action canceled. (" + fileTarget + "\\" + fi.Name + " already exists)" + Environment.NewLine);
                    //    }));
                    //}
                }
                catch (Exception ex)
                {
                    // Console.WriteLine("file=" + fileSource + " error=" + ex.Message);
                }

            });




            txtLog.Invoke(new Action(() =>
            {
                txtLog.AppendText("Moving files done." + Environment.NewLine + "Removing Empty Folders.." + Environment.NewLine);
            }));

            try
            {
                RemoveEmptyDirectories(folderPath);
            }
            catch (Exception)
            {


            }


            txtLog.Invoke(new Action(() =>
            {
                txtLog.AppendText("done");
            }));






        }

        private string GetNextFileName(string fileName)
        {
            string extension = Path.GetExtension(fileName);

            int i = 0;
            while (File.Exists(fileName))
            {
                if (i == 0)
                    fileName = fileName.Replace(extension, "(" + ++i + ")" + extension);
                else
                    fileName = fileName.Replace("(" + i + ")" + extension, "(" + ++i + ")" + extension);
            }

            return fileName;
        }
        private static void RemoveEmptyDirectories(string startLocation)
        {
            foreach (var directory in Directory.GetDirectories(startLocation))
            {
                RemoveEmptyDirectories(directory);
                if (Directory.GetFiles(directory).Length == 0 &&
                    Directory.GetDirectories(directory).Length == 0)
                {
                    Directory.Delete(directory, false);
                }
            }
        }

        public bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }

        private static Regex r = new Regex(":");
        private static DateTime GetDateTaken(string fileName)
        {

            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (Image myImage = Image.FromStream(fs, false, false))
                {
                    PropertyItem propItem = myImage.GetPropertyItem(36867);
                    string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                    return DateTime.Parse(dateTaken);
                }
            }
        }

        public static readonly HashAlgorithm SHA1 = new SHA1Managed();
        public static string FileToMD5Hash(string filePath)
        {

            using (var stream = new BufferedStream(File.OpenRead(filePath), 100000))
            {
                byte[] hash = SHA1.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        //private string FileToMD5Hash(string _fileName)
        //{
        //    var returnString = string.Empty;
        //    try
        //    {
        //        using (var stream = new BufferedStream(File.OpenRead(_fileName), 1200000))
        //        {
        //            SHA256Managed sha = new SHA256Managed();
        //            byte[] checksum = sha.ComputeHash(stream);
        //            returnString = BitConverter.ToString(checksum).Replace("-", string.Empty);
        //        }
        //    }
        //    catch
        //    { }
        //    return returnString;



        //}

        private void btnPath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtpath.Text = folderBrowserDialog1.SelectedPath;

            }
        }


        static readonly object lockObject = new Object();

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            string backupFolder = "";
            if (radioButtonMove.Checked)
            {

                backupFolder = txtpath.Text + "\\" + BACKUP_PATH + DateTime.Today.ToString("dd_MM_yyyy");
                if (!Directory.Exists(backupFolder))
                {
                    try
                    {
                        Directory.CreateDirectory(backupFolder);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot create directory:" + backupFolder + "\nError:" + ex.ToString());
                        return;
                    }
                }
            }

            lblStatus.Invoke(new Action(() =>
            {
                lblStatus.Text = "processing ";
            }
            ));


            txtLog.Invoke(new Action(() =>
            {
                txtLog.Text = "";
            }
            ));

            var folder = txtpath.Text;
            var files = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);

            List<FileData> filesList = new List<FileData>();

            foreach (var path in files)
            {

                try
                {
                    if (path.ToLower().Contains(BACKUP_PATH)) continue;

                    FileInfo finfo = new FileInfo(path);
                    filesList.Add(new FileData
                    {
                        fileSize = finfo.Length,
                        path = finfo.FullName
                    });
                }
                catch (Exception)
                {

                }
            }



            var duplicates =
                filesList
                    .Where(fd => fd != null)
                    .GroupBy(filedata => filedata.fileSize)
                    .Where(g => g.Count() > 1)
                    .ToArray();



            counter = 0;
            Parallel.ForEach(duplicates, group =>
            {

                foreach (var item in group)
                {
                    item.fileHash = FileToMD5Hash(item.path);
                }

                var identicalByHash =
                    group.
                        GroupBy(filedata => filedata.fileHash)
                        .Where(g => g.Count() > 1)
                        .ToArray();


                Parallel.ForEach(identicalByHash, hashGroup =>
                {

                    StringBuilder sb = new StringBuilder();
                    int i = 0;
                    foreach (var item in hashGroup)
                    {
                        if (i >= 1)
                        {
                            if (radioButtonMove.Checked)
                            {
                                string moveToPath;
                                try
                                {
                                    moveToPath = backupFolder + "\\" + Path.GetFileName(item.path);
                                    if (File.Exists(moveToPath))
                                    {
                                        lock (lockObject)
                                        {
                                            moveToPath = GetNextFileName(moveToPath);
                                        }
                                    }

                                    File.Move(item.path, moveToPath);
                                    sb.Append(item.path + "\t\t" + item.fileSize + " bytes \t\t" + item.fileHash + " - Moved" + Environment.NewLine);

                                }
                                catch (Exception ex)
                                {
                                    sb.Append("Error moving file. " + item.path + "\t\t" + item.fileSize + " bytes \t\t" + item.fileHash + Environment.NewLine + "error = " + ex.Message + Environment.NewLine);
                                }
                            }
                            else if (radioButtonDelete.Checked)
                            {
                                try
                                {
                                    File.Delete(item.path);
                                    sb.Append(item.path + "\t\t" + item.fileSize + " bytes \t\t" + item.fileHash + " - Deleted" + Environment.NewLine);
                                }
                                catch (Exception ex)
                                {

                                    sb.Append("Error deleting file. " + item.path + "\t\t" + item.fileSize + " bytes \t\t" + item.fileHash + Environment.NewLine + "error = " + ex.Message + Environment.NewLine);
                                }
                            }
                            else
                            {
                                sb.Append(item.path + "\t\t" + item.fileSize + " bytes \t\t" + item.fileHash + Environment.NewLine);
                            }
                        }
                        else
                        {
                            sb.Append(item.path + "\t\t" + item.fileSize + " bytes \t\t" + item.fileHash + Environment.NewLine);
                        }

                        i++;
                    }

                    txtLog.Invoke(new Action(() =>
                    {
                        txtLog.AppendText(Environment.NewLine + Interlocked.Increment(ref counter) + ". (" + hashGroup.Count() + ")\n" + Environment.NewLine + sb.ToString());
                    }));

                    lblStatus.Invoke(new Action(() =>
                    {
                        lblStatus.Text = "processing " + counter;
                    }
           ));

                });





            });





            lblStatus.Invoke(new Action(() =>
            {
                lblStatus.Text = "done";
            }
               ));
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            bw.RunWorkerAsync();
        }

        private void duplicateFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDuplicates.Visible = true;
            panelMediaByMonth.Visible = false;
        }

        private void arrangeByMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDuplicates.Visible = false;
            panelMediaByMonth.Visible = true;
            panelMediaByMonth.Left = panelDuplicates.Left;
            panelMediaByMonth.Top = panelDuplicates.Top;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelMediaByMonth.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtTargetFolder.Text = folderBrowserDialog1.SelectedPath;

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            bw2.RunWorkerAsync();
        }


    }


    public class FileData
    {

        public string path;
        public long fileSize;
        public string fileHash;
    }
}
