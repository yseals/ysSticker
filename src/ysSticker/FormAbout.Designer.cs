namespace ysSticker
{
    partial class FormAbout
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.linkLblGitUrl = new System.Windows.Forms.LinkLabel();
            this.lblCreater = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProductName.ForeColor = System.Drawing.Color.Maroon;
            this.lblProductName.Location = new System.Drawing.Point(68, 125);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(177, 50);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "アプリ名";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.lblVersion.ForeColor = System.Drawing.Color.Maroon;
            this.lblVersion.Location = new System.Drawing.Point(192, 300);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(188, 40);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Ver.0.0.0.0";
            // 
            // linkLblGitUrl
            // 
            this.linkLblGitUrl.AutoSize = true;
            this.linkLblGitUrl.BackColor = System.Drawing.Color.Transparent;
            this.linkLblGitUrl.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.linkLblGitUrl.ForeColor = System.Drawing.Color.Maroon;
            this.linkLblGitUrl.LinkColor = System.Drawing.Color.Blue;
            this.linkLblGitUrl.Location = new System.Drawing.Point(85, 254);
            this.linkLblGitUrl.Name = "linkLblGitUrl";
            this.linkLblGitUrl.Size = new System.Drawing.Size(59, 24);
            this.linkLblGitUrl.TabIndex = 2;
            this.linkLblGitUrl.TabStop = true;
            this.linkLblGitUrl.Text = "giturl";
            this.linkLblGitUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblGitUrl_LinkClicked);
            // 
            // lblCreater
            // 
            this.lblCreater.AutoSize = true;
            this.lblCreater.BackColor = System.Drawing.Color.Transparent;
            this.lblCreater.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.lblCreater.ForeColor = System.Drawing.Color.Maroon;
            this.lblCreater.Location = new System.Drawing.Point(195, 198);
            this.lblCreater.Name = "lblCreater";
            this.lblCreater.Size = new System.Drawing.Size(101, 24);
            this.lblCreater.TabIndex = 1;
            this.lblCreater.Text = "by yseals";
            // 
            // FormAbout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 422);
            this.ControlBox = false;
            this.Controls.Add(this.lblCreater);
            this.Controls.Add(this.linkLblGitUrl);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblProductName);
            this.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbout";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Deactivate += new System.EventHandler(this.FormAbout_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel linkLblGitUrl;
        private System.Windows.Forms.Label lblCreater;
    }
}
