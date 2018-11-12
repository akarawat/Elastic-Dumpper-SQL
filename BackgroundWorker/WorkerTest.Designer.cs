namespace WorkerTest
{
    partial class WorkerTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerTest));
            this.LstStatus = new System.Windows.Forms.ListBox();
            this.BgrdWorker = new System.ComponentModel.BackgroundWorker();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ButCancel = new System.Windows.Forms.Button();
            this.ButGo = new System.Windows.Forms.Button();
            this.TxtFile = new System.Windows.Forms.TextBox();
            this.ButChooseFile = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.LblPercent = new System.Windows.Forms.Label();
            this.ButClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnMgrDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstStatus
            // 
            this.LstStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstStatus.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstStatus.FormattingEnabled = true;
            this.LstStatus.ItemHeight = 14;
            this.LstStatus.Location = new System.Drawing.Point(9, 116);
            this.LstStatus.Name = "LstStatus";
            this.LstStatus.Size = new System.Drawing.Size(456, 326);
            this.LstStatus.TabIndex = 0;
            // 
            // BgrdWorker
            // 
            this.BgrdWorker.WorkerReportsProgress = true;
            this.BgrdWorker.WorkerSupportsCancellation = true;
            this.BgrdWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgrdWorker_DoWork);
            this.BgrdWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgrdWorker_ProgressChanged);
            this.BgrdWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgrdWorker_RunWorkerCompleted);
            // 
            // Progress
            // 
            this.Progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Progress.Location = new System.Drawing.Point(45, 97);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(420, 13);
            this.Progress.TabIndex = 1;
            // 
            // FileDialog
            // 
            this.FileDialog.Filter = "Text files|*.txt|All files|*.*";
            // 
            // ButCancel
            // 
            this.ButCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButCancel.Enabled = false;
            this.ButCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButCancel.Location = new System.Drawing.Point(435, 66);
            this.ButCancel.Name = "ButCancel";
            this.ButCancel.Size = new System.Drawing.Size(30, 23);
            this.ButCancel.TabIndex = 11;
            this.ButCancel.Text = "[]";
            this.ButCancel.UseVisualStyleBackColor = true;
            this.ButCancel.Click += new System.EventHandler(this.ButCancel_Click);
            // 
            // ButGo
            // 
            this.ButGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButGo.Enabled = false;
            this.ButGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButGo.Location = new System.Drawing.Point(399, 66);
            this.ButGo.Name = "ButGo";
            this.ButGo.Size = new System.Drawing.Size(30, 23);
            this.ButGo.TabIndex = 10;
            this.ButGo.Text = ">";
            this.ButGo.UseVisualStyleBackColor = true;
            this.ButGo.Click += new System.EventHandler(this.ButGo_Click);
            // 
            // TxtFile
            // 
            this.TxtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFile.Location = new System.Drawing.Point(45, 68);
            this.TxtFile.Name = "TxtFile";
            this.TxtFile.Size = new System.Drawing.Size(312, 20);
            this.TxtFile.TabIndex = 9;
            // 
            // ButChooseFile
            // 
            this.ButChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButChooseFile.Location = new System.Drawing.Point(363, 66);
            this.ButChooseFile.Name = "ButChooseFile";
            this.ButChooseFile.Size = new System.Drawing.Size(30, 23);
            this.ButChooseFile.TabIndex = 8;
            this.ButChooseFile.Text = "...";
            this.ButChooseFile.UseVisualStyleBackColor = true;
            this.ButChooseFile.Click += new System.EventHandler(this.ButChooseFile_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(6, 71);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(26, 13);
            this.lblFile.TabIndex = 7;
            this.lblFile.Text = "File:";
            // 
            // LblPercent
            // 
            this.LblPercent.AutoSize = true;
            this.LblPercent.Location = new System.Drawing.Point(6, 97);
            this.LblPercent.Name = "LblPercent";
            this.LblPercent.Size = new System.Drawing.Size(33, 13);
            this.LblPercent.TabIndex = 12;
            this.LblPercent.Text = "100%";
            // 
            // ButClear
            // 
            this.ButClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButClear.Location = new System.Drawing.Point(9, 449);
            this.ButClear.Name = "ButClear";
            this.ButClear.Size = new System.Drawing.Size(45, 23);
            this.ButClear.TabIndex = 13;
            this.ButClear.Text = "Clear";
            this.ButClear.UseVisualStyleBackColor = true;
            this.ButClear.Click += new System.EventHandler(this.ButClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(358, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "URL";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtType.Location = new System.Drawing.Point(404, 23);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(54, 23);
            this.txtType.TabIndex = 14;
            this.txtType.Text = "1";
            this.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtUrl.Location = new System.Drawing.Point(45, 23);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(307, 23);
            this.txtUrl.TabIndex = 15;
            this.txtUrl.Text = "http://172.21.42.114:9200/uiddb/uidall/";
            // 
            // btnMgrDb
            // 
            this.btnMgrDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMgrDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMgrDb.Location = new System.Drawing.Point(420, 449);
            this.btnMgrDb.Name = "btnMgrDb";
            this.btnMgrDb.Size = new System.Drawing.Size(45, 23);
            this.btnMgrDb.TabIndex = 13;
            this.btnMgrDb.Text = "DB";
            this.btnMgrDb.UseVisualStyleBackColor = true;
            this.btnMgrDb.Click += new System.EventHandler(this.btnMgrDb_Click);
            // 
            // WorkerTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnMgrDb);
            this.Controls.Add(this.ButClear);
            this.Controls.Add(this.LblPercent);
            this.Controls.Add(this.ButCancel);
            this.Controls.Add(this.ButGo);
            this.Controls.Add(this.TxtFile);
            this.Controls.Add(this.ButChooseFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.LstStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(248, 243);
            this.Name = "WorkerTest";
            this.Text = "Migratedata To Elastic By Tomy";
            this.Load += new System.EventHandler(this.WorkerTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstStatus;
        private System.ComponentModel.BackgroundWorker BgrdWorker;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Button ButCancel;
        private System.Windows.Forms.Button ButGo;
        private System.Windows.Forms.TextBox TxtFile;
        private System.Windows.Forms.Button ButChooseFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label LblPercent;
        private System.Windows.Forms.Button ButClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnMgrDb;
    }
}

