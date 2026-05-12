namespace ysSticker
{
    partial class FormConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.lblDisplayText = new System.Windows.Forms.Label();
            this.txtDisplayText = new System.Windows.Forms.TextBox();
            this.lblDisplayFont = new System.Windows.Forms.Label();
            this.lblDisplayColor = new System.Windows.Forms.Label();
            this.btnFontSelect = new System.Windows.Forms.Button();
            this.btnColorSelect = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDisplaySambleView = new System.Windows.Forms.Label();
            this.lblDisplaySample = new System.Windows.Forms.Label();
            this.fontDialogObj = new System.Windows.Forms.FontDialog();
            this.colorDialogObj = new System.Windows.Forms.ColorDialog();
            this.txtDisplayFont = new System.Windows.Forms.TextBox();
            this.txtDisplayColor = new System.Windows.Forms.TextBox();
            this.pnlSampleView = new System.Windows.Forms.Panel();
            this.pnlSampleView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisplayText
            // 
            this.lblDisplayText.AutoSize = true;
            this.lblDisplayText.Location = new System.Drawing.Point(26, 26);
            this.lblDisplayText.Name = "lblDisplayText";
            this.lblDisplayText.Size = new System.Drawing.Size(89, 20);
            this.lblDisplayText.TabIndex = 0;
            this.lblDisplayText.Text = "表示文字";
            // 
            // txtDisplayText
            // 
            this.txtDisplayText.Location = new System.Drawing.Point(30, 54);
            this.txtDisplayText.Multiline = true;
            this.txtDisplayText.Name = "txtDisplayText";
            this.txtDisplayText.Size = new System.Drawing.Size(345, 117);
            this.txtDisplayText.TabIndex = 1;
            this.txtDisplayText.TextChanged += new System.EventHandler(this.txtDisplayText_TextChanged);
            // 
            // lblDisplayFont
            // 
            this.lblDisplayFont.AutoSize = true;
            this.lblDisplayFont.Location = new System.Drawing.Point(26, 196);
            this.lblDisplayFont.Name = "lblDisplayFont";
            this.lblDisplayFont.Size = new System.Drawing.Size(65, 20);
            this.lblDisplayFont.TabIndex = 2;
            this.lblDisplayFont.Text = "フォント";
            // 
            // lblDisplayColor
            // 
            this.lblDisplayColor.AutoSize = true;
            this.lblDisplayColor.Location = new System.Drawing.Point(26, 307);
            this.lblDisplayColor.Name = "lblDisplayColor";
            this.lblDisplayColor.Size = new System.Drawing.Size(29, 20);
            this.lblDisplayColor.TabIndex = 5;
            this.lblDisplayColor.Text = "色";
            // 
            // btnFontSelect
            // 
            this.btnFontSelect.Location = new System.Drawing.Point(307, 262);
            this.btnFontSelect.Name = "btnFontSelect";
            this.btnFontSelect.Size = new System.Drawing.Size(68, 33);
            this.btnFontSelect.TabIndex = 4;
            this.btnFontSelect.Text = "選択";
            this.btnFontSelect.UseVisualStyleBackColor = true;
            this.btnFontSelect.Click += new System.EventHandler(this.btnFontSelect_Click);
            // 
            // btnColorSelect
            // 
            this.btnColorSelect.Location = new System.Drawing.Point(188, 301);
            this.btnColorSelect.Name = "btnColorSelect";
            this.btnColorSelect.Size = new System.Drawing.Size(68, 33);
            this.btnColorSelect.TabIndex = 7;
            this.btnColorSelect.Text = "選択";
            this.btnColorSelect.UseVisualStyleBackColor = true;
            this.btnColorSelect.Click += new System.EventHandler(this.btnColorSelect_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(86, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 49);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "設定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 49);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDisplaySambleView
            // 
            this.lblDisplaySambleView.AutoSize = true;
            this.lblDisplaySambleView.BackColor = System.Drawing.Color.White;
            this.lblDisplaySambleView.Location = new System.Drawing.Point(0, 2);
            this.lblDisplaySambleView.Name = "lblDisplaySambleView";
            this.lblDisplaySambleView.Size = new System.Drawing.Size(70, 20);
            this.lblDisplaySambleView.TabIndex = 0;
            this.lblDisplaySambleView.Text = "Sample";
            this.lblDisplaySambleView.UseMnemonic = false;
            // 
            // lblDisplaySample
            // 
            this.lblDisplaySample.AutoSize = true;
            this.lblDisplaySample.Location = new System.Drawing.Point(405, 26);
            this.lblDisplaySample.Name = "lblDisplaySample";
            this.lblDisplaySample.Size = new System.Drawing.Size(111, 20);
            this.lblDisplaySample.TabIndex = 10;
            this.lblDisplaySample.Text = "表示サンプル";
            // 
            // txtDisplayFont
            // 
            this.txtDisplayFont.BackColor = System.Drawing.Color.White;
            this.txtDisplayFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplayFont.ForeColor = System.Drawing.Color.Black;
            this.txtDisplayFont.Location = new System.Drawing.Point(30, 229);
            this.txtDisplayFont.Name = "txtDisplayFont";
            this.txtDisplayFont.ReadOnly = true;
            this.txtDisplayFont.Size = new System.Drawing.Size(345, 27);
            this.txtDisplayFont.TabIndex = 3;
            // 
            // txtDisplayColor
            // 
            this.txtDisplayColor.BackColor = System.Drawing.Color.White;
            this.txtDisplayColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplayColor.ForeColor = System.Drawing.Color.Black;
            this.txtDisplayColor.Location = new System.Drawing.Point(97, 305);
            this.txtDisplayColor.Name = "txtDisplayColor";
            this.txtDisplayColor.ReadOnly = true;
            this.txtDisplayColor.Size = new System.Drawing.Size(74, 27);
            this.txtDisplayColor.TabIndex = 6;
            // 
            // pnlSampleView
            // 
            this.pnlSampleView.AutoScroll = true;
            this.pnlSampleView.BackColor = System.Drawing.Color.White;
            this.pnlSampleView.Controls.Add(this.lblDisplaySambleView);
            this.pnlSampleView.Location = new System.Drawing.Point(409, 54);
            this.pnlSampleView.Name = "pnlSampleView";
            this.pnlSampleView.Size = new System.Drawing.Size(451, 289);
            this.pnlSampleView.TabIndex = 14;
            // 
            // FormConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 436);
            this.Controls.Add(this.pnlSampleView);
            this.Controls.Add(this.txtDisplayColor);
            this.Controls.Add(this.lblDisplaySample);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnColorSelect);
            this.Controls.Add(this.txtDisplayFont);
            this.Controls.Add(this.btnFontSelect);
            this.Controls.Add(this.lblDisplayColor);
            this.Controls.Add(this.lblDisplayFont);
            this.Controls.Add(this.txtDisplayText);
            this.Controls.Add(this.lblDisplayText);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfig";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "設定";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.pnlSampleView.ResumeLayout(false);
            this.pnlSampleView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplayText;
        private System.Windows.Forms.TextBox txtDisplayText;
        private System.Windows.Forms.Label lblDisplayFont;
        private System.Windows.Forms.Label lblDisplayColor;
        private System.Windows.Forms.Button btnFontSelect;
        private System.Windows.Forms.Button btnColorSelect;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDisplaySambleView;
        private System.Windows.Forms.Label lblDisplaySample;
        private System.Windows.Forms.FontDialog fontDialogObj;
        private System.Windows.Forms.ColorDialog colorDialogObj;
        private System.Windows.Forms.TextBox txtDisplayFont;
        private System.Windows.Forms.TextBox txtDisplayColor;
        private System.Windows.Forms.Panel pnlSampleView;
    }
}