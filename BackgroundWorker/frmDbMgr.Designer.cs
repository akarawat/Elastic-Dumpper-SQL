namespace WorkerTest
{
    partial class frmDbMgr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDbMgr));
            this.txtSrv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.txtResText = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtView = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDocNoSt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblSucc = new System.Windows.Forms.Label();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSrv
            // 
            this.txtSrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtSrv.Location = new System.Drawing.Point(111, 105);
            this.txtSrv.Name = "txtSrv";
            this.txtSrv.Size = new System.Drawing.Size(172, 23);
            this.txtSrv.TabIndex = 0;
            this.txtSrv.Text = "THAY-S-DB04";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(26, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(26, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "login";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtLogin.Location = new System.Drawing.Point(111, 131);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(172, 23);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Text = "ITOperation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(26, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "pass";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtpass.Location = new System.Drawing.Point(111, 157);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(172, 23);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "KMPLLc[C6ZHBSQXl";
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(26, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "DB";
            // 
            // txtDb
            // 
            this.txtDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDb.Location = new System.Drawing.Point(111, 183);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(172, 23);
            this.txtDb.TabIndex = 3;
            this.txtDb.Text = "CTT_TH_SMT4";
            // 
            // btnTestConn
            // 
            this.btnTestConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnTestConn.Location = new System.Drawing.Point(289, 105);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(75, 46);
            this.btnTestConn.TabIndex = 7;
            this.btnTestConn.Text = "Test Conn";
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // txtResText
            // 
            this.txtResText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtResText.Location = new System.Drawing.Point(370, 105);
            this.txtResText.Multiline = true;
            this.txtResText.Name = "txtResText";
            this.txtResText.Size = new System.Drawing.Size(326, 159);
            this.txtResText.TabIndex = 11;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnGo.Location = new System.Drawing.Point(621, 481);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 46);
            this.btnGo.TabIndex = 12;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtQuery.Location = new System.Drawing.Point(29, 313);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(667, 162);
            this.txtQuery.TabIndex = 15;
            this.txtQuery.Text = "select SmartracBatch, ChipLot, IdentifierChip, IdentifierOS, IdentifierOSVersion," +
    " UID, BoxNr, status, teststatus, info1, info2, info3, info4, info5, ProductionDa" +
    "te, [DateTime]  from view_lxs\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(26, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Query >>>";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 538);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(667, 23);
            this.progressBar1.TabIndex = 17;
            // 
            // txtView
            // 
            this.txtView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtView.Location = new System.Drawing.Point(111, 212);
            this.txtView.Name = "txtView";
            this.txtView.Size = new System.Drawing.Size(253, 21);
            this.txtView.TabIndex = 4;
            this.txtView.Text = "View_SMTTH4_DTC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(26, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Table-View";
            // 
            // txtDocNoSt
            // 
            this.txtDocNoSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDocNoSt.Location = new System.Drawing.Point(141, 241);
            this.txtDocNoSt.Name = "txtDocNoSt";
            this.txtDocNoSt.Size = new System.Drawing.Size(142, 23);
            this.txtDocNoSt.TabIndex = 5;
            this.txtDocNoSt.Text = "1";
            this.txtDocNoSt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(26, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Doc No. Start at";
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtUrl.Location = new System.Drawing.Point(76, 270);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(288, 23);
            this.txtUrl.TabIndex = 6;
            this.txtUrl.Text = "http://172.21.42.114:9200/uiddb/uidall/";
            this.txtUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(26, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "URL :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(330, 483);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 36);
            this.label9.TabIndex = 18;
            this.label9.Text = "Rows :";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblRows.ForeColor = System.Drawing.Color.Green;
            this.lblRows.Location = new System.Drawing.Point(443, 483);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(28, 39);
            this.lblRows.TabIndex = 19;
            this.lblRows.Text = "-";
            // 
            // lblSucc
            // 
            this.lblSucc.AutoSize = true;
            this.lblSucc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSucc.ForeColor = System.Drawing.Color.Green;
            this.lblSucc.Location = new System.Drawing.Point(29, 497);
            this.lblSucc.Name = "lblSucc";
            this.lblSucc.Size = new System.Drawing.Size(0, 17);
            this.lblSucc.TabIndex = 20;
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(370, 273);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(123, 17);
            this.chkDebug.TabIndex = 21;
            this.chkDebug.Text = "Debug UID Text File";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(23, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(355, 36);
            this.label10.TabIndex = 18;
            this.label10.Text = "Migration Big Data Server";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WorkerTest.Properties.Resources.LLogo;
            this.pictureBox1.Location = new System.Drawing.Point(458, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmDbMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 582);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkDebug);
            this.Controls.Add(this.lblSucc);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtResText);
            this.Controls.Add(this.btnTestConn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtDocNoSt);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.txtDb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSrv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDbMgr";
            this.Text = "Migrate from Data adaptor";
            this.Load += new System.EventHandler(this.frmDbMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDb;
        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.TextBox txtResText;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDocNoSt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblSucc;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}