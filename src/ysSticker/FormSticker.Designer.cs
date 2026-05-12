namespace ysSticker
{
    partial class FormSticker
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSticker));
            this.taskTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.taskTrayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.VersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskTrayMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskTrayIcon
            // 
            this.taskTrayIcon.ContextMenuStrip = this.taskTrayMenuStrip;
            this.taskTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("taskTrayIcon.Icon")));
            this.taskTrayIcon.Text = "ysSticker";
            this.taskTrayIcon.Visible = true;
            // 
            // taskTrayMenuStrip
            // 
            this.taskTrayMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.taskTrayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingToolStripMenuItem,
            this.toolStripSeparator1,
            this.VersionToolStripMenuItem,
            this.toolStripSeparator2,
            this.EndToolStripMenuItem});
            this.taskTrayMenuStrip.Name = "taskTrayMenuStrip";
            this.taskTrayMenuStrip.Size = new System.Drawing.Size(133, 88);
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.SettingToolStripMenuItem.Text = "設定";
            this.SettingToolStripMenuItem.Click += new System.EventHandler(this.SettingToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // VersionToolStripMenuItem
            // 
            this.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem";
            this.VersionToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.VersionToolStripMenuItem.Text = "バージョン";
            this.VersionToolStripMenuItem.Click += new System.EventHandler(this.VersionToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(129, 6);
            // 
            // EndToolStripMenuItem
            // 
            this.EndToolStripMenuItem.Name = "EndToolStripMenuItem";
            this.EndToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.EndToolStripMenuItem.Text = "終了";
            this.EndToolStripMenuItem.Click += new System.EventHandler(this.EndToolStripMenuItem_Click);
            // 
            // FormSticker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Lime;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(692, 318);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSticker";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sticker";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormSticker_Paint);
            this.taskTrayMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon taskTrayIcon;
        private System.Windows.Forms.ContextMenuStrip taskTrayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem VersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem EndToolStripMenuItem;
    }
}

