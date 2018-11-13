namespace WorkerTest
{
    partial class jSonResult
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnJson = new System.Windows.Forms.Button();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.chkTxt = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtJsonRes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtUrl.Location = new System.Drawing.Point(69, 23);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(307, 23);
            this.txtUrl.TabIndex = 17;
            this.txtUrl.Text = "http://172.21.42.114:9200/uiddb/uidall/_count";
            // 
            // btnJson
            // 
            this.btnJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJson.Location = new System.Drawing.Point(382, 23);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(74, 23);
            this.btnJson.TabIndex = 18;
            this.btnJson.Text = "Get";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(614, 27);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(108, 17);
            this.chkDebug.TabIndex = 20;
            this.chkDebug.Text = "Debug json to file";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // chkTxt
            // 
            this.chkTxt.AutoSize = true;
            this.chkTxt.Location = new System.Drawing.Point(462, 27);
            this.chkTxt.Name = "chkTxt";
            this.chkTxt.Size = new System.Drawing.Size(132, 17);
            this.chkTxt.TabIndex = 21;
            this.chkTxt.Text = "Debug json to text box";
            this.chkTxt.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(19, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "URL :";
            // 
            // txtJsonRes
            // 
            this.txtJsonRes.Location = new System.Drawing.Point(12, 68);
            this.txtJsonRes.Name = "txtJsonRes";
            this.txtJsonRes.Size = new System.Drawing.Size(710, 434);
            this.txtJsonRes.TabIndex = 23;
            this.txtJsonRes.Text = "";
            // 
            // jSonResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 514);
            this.Controls.Add(this.txtJsonRes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkTxt);
            this.Controls.Add(this.chkDebug);
            this.Controls.Add(this.btnJson);
            this.Controls.Add(this.txtUrl);
            this.Name = "jSonResult";
            this.Text = "jSonResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnJson;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.CheckBox chkTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtJsonRes;
    }
}