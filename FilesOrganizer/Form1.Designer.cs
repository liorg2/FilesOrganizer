namespace FilesOrgenizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeByMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDuplicates = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.radioButtonMove = new System.Windows.Forms.RadioButton();
            this.radioButtonAnalyze = new System.Windows.Forms.RadioButton();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.panelMediaByMonth = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTargetFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGOOrganizeByMonth = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonMonthAsNumber = new System.Windows.Forms.RadioButton();
            this.radioButtonMonthNames = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panelDuplicates.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelMediaByMonth.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(27, 103);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(1002, 369);
            this.txtLog.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(24, 484);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duplicateFilesToolStripMenuItem,
            this.arrangeByMonthToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // duplicateFilesToolStripMenuItem
            // 
            this.duplicateFilesToolStripMenuItem.Name = "duplicateFilesToolStripMenuItem";
            this.duplicateFilesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.duplicateFilesToolStripMenuItem.Text = "Duplicate Files";
            this.duplicateFilesToolStripMenuItem.Click += new System.EventHandler(this.duplicateFilesToolStripMenuItem_Click);
            // 
            // arrangeByMonthToolStripMenuItem
            // 
            this.arrangeByMonthToolStripMenuItem.Name = "arrangeByMonthToolStripMenuItem";
            this.arrangeByMonthToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.arrangeByMonthToolStripMenuItem.Text = "Arrange By Month";
            this.arrangeByMonthToolStripMenuItem.Click += new System.EventHandler(this.arrangeByMonthToolStripMenuItem_Click);
            // 
            // panelDuplicates
            // 
            this.panelDuplicates.Controls.Add(this.label3);
            this.panelDuplicates.Controls.Add(this.label1);
            this.panelDuplicates.Controls.Add(this.btnGo);
            this.panelDuplicates.Controls.Add(this.groupBox1);
            this.panelDuplicates.Controls.Add(this.btnPath);
            this.panelDuplicates.Controls.Add(this.txtpath);
            this.panelDuplicates.Location = new System.Drawing.Point(27, 27);
            this.panelDuplicates.Name = "panelDuplicates";
            this.panelDuplicates.Size = new System.Drawing.Size(950, 70);
            this.panelDuplicates.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Media Folder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-372, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Folder:";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(841, 15);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 13;
            this.btnGo.Text = "Run";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDelete);
            this.groupBox1.Controls.Add(this.radioButtonMove);
            this.groupBox1.Controls.Add(this.radioButtonAnalyze);
            this.groupBox1.Location = new System.Drawing.Point(533, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 47);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action to take with duplicate files";
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(219, 19);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(56, 17);
            this.radioButtonDelete.TabIndex = 3;
            this.radioButtonDelete.Text = "Delete";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            // 
            // radioButtonMove
            // 
            this.radioButtonMove.AutoSize = true;
            this.radioButtonMove.Location = new System.Drawing.Point(77, 19);
            this.radioButtonMove.Name = "radioButtonMove";
            this.radioButtonMove.Size = new System.Drawing.Size(136, 17);
            this.radioButtonMove.TabIndex = 2;
            this.radioButtonMove.Text = "Move to Backup Folder";
            this.radioButtonMove.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnalyze
            // 
            this.radioButtonAnalyze.AutoSize = true;
            this.radioButtonAnalyze.Checked = true;
            this.radioButtonAnalyze.Location = new System.Drawing.Point(6, 19);
            this.radioButtonAnalyze.Name = "radioButtonAnalyze";
            this.radioButtonAnalyze.Size = new System.Drawing.Size(65, 17);
            this.radioButtonAnalyze.TabIndex = 0;
            this.radioButtonAnalyze.TabStop = true;
            this.radioButtonAnalyze.Text = "Log only";
            this.radioButtonAnalyze.UseVisualStyleBackColor = true;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(486, 21);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(28, 20);
            this.btnPath.TabIndex = 11;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(83, 20);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(397, 20);
            this.txtpath.TabIndex = 10;
            // 
            // panelMediaByMonth
            // 
            this.panelMediaByMonth.Controls.Add(this.label5);
            this.panelMediaByMonth.Controls.Add(this.label4);
            this.panelMediaByMonth.Controls.Add(this.button3);
            this.panelMediaByMonth.Controls.Add(this.txtTargetFolder);
            this.panelMediaByMonth.Controls.Add(this.label2);
            this.panelMediaByMonth.Controls.Add(this.btnGOOrganizeByMonth);
            this.panelMediaByMonth.Controls.Add(this.groupBox2);
            this.panelMediaByMonth.Controls.Add(this.button2);
            this.panelMediaByMonth.Controls.Add(this.txtFolderPath);
            this.panelMediaByMonth.Location = new System.Drawing.Point(27, 113);
            this.panelMediaByMonth.Name = "panelMediaByMonth";
            this.panelMediaByMonth.Size = new System.Drawing.Size(950, 68);
            this.panelMediaByMonth.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Target Folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Media Folder";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(486, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 20);
            this.button3.TabIndex = 16;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTargetFolder
            // 
            this.txtTargetFolder.Location = new System.Drawing.Point(83, 31);
            this.txtTargetFolder.Name = "txtTargetFolder";
            this.txtTargetFolder.Size = new System.Drawing.Size(397, 20);
            this.txtTargetFolder.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-372, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Folder:";
            // 
            // btnGOOrganizeByMonth
            // 
            this.btnGOOrganizeByMonth.Location = new System.Drawing.Point(841, 17);
            this.btnGOOrganizeByMonth.Name = "btnGOOrganizeByMonth";
            this.btnGOOrganizeByMonth.Size = new System.Drawing.Size(75, 23);
            this.btnGOOrganizeByMonth.TabIndex = 13;
            this.btnGOOrganizeByMonth.Text = "Run";
            this.btnGOOrganizeByMonth.UseVisualStyleBackColor = true;
            this.btnGOOrganizeByMonth.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonMonthAsNumber);
            this.groupBox2.Controls.Add(this.radioButtonMonthNames);
            this.groupBox2.Location = new System.Drawing.Point(533, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 47);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folder names";
            // 
            // radioButtonMonthAsNumber
            // 
            this.radioButtonMonthAsNumber.AutoSize = true;
            this.radioButtonMonthAsNumber.Checked = true;
            this.radioButtonMonthAsNumber.Location = new System.Drawing.Point(111, 19);
            this.radioButtonMonthAsNumber.Name = "radioButtonMonthAsNumber";
            this.radioButtonMonthAsNumber.Size = new System.Drawing.Size(95, 17);
            this.radioButtonMonthAsNumber.TabIndex = 3;
            this.radioButtonMonthAsNumber.TabStop = true;
            this.radioButtonMonthAsNumber.Text = "Month Number";
            this.radioButtonMonthAsNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonthNames
            // 
            this.radioButtonMonthNames.AutoSize = true;
            this.radioButtonMonthNames.Location = new System.Drawing.Point(19, 19);
            this.radioButtonMonthNames.Name = "radioButtonMonthNames";
            this.radioButtonMonthNames.Size = new System.Drawing.Size(86, 17);
            this.radioButtonMonthNames.TabIndex = 2;
            this.radioButtonMonthNames.Text = "Month Name";
            this.radioButtonMonthNames.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 20);
            this.button2.TabIndex = 11;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(83, 5);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(397, 20);
            this.txtFolderPath.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 546);
            this.Controls.Add(this.panelMediaByMonth);
            this.Controls.Add(this.panelDuplicates);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDuplicates.ResumeLayout(false);
            this.panelDuplicates.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelMediaByMonth.ResumeLayout(false);
            this.panelMediaByMonth.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeByMonthToolStripMenuItem;
        private System.Windows.Forms.Panel panelDuplicates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioButtonMove;
        private System.Windows.Forms.RadioButton radioButtonAnalyze;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Panel panelMediaByMonth;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtTargetFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGOOrganizeByMonth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonMonthAsNumber;
        private System.Windows.Forms.RadioButton radioButtonMonthNames;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

