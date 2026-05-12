using System;
using System.Reflection;
using System.Windows.Forms;

namespace ysSticker
{
    partial class FormAbout : Form
    {
        /// <summary>
        /// GitHubのURL
        /// </summary>
        private readonly string MyGitHubUrl = "https://github.com/yseals";

        public FormAbout()
        {
            InitializeComponent();

            // アセンブリ情報をフォームに表示する
            this.Text = AssemblyTitle + "バージョン";
            this.lblProductName.Text = AssemblyProduct;
            this.lblVersion.Text = "Ver." + AssemblyVersion;
            this.lblCreater.Text = "by " + AssemblyCompany;
            this.linkLblGitUrl.Text = MyGitHubUrl;
        }

        /// <summary>
        /// フォームが非アクティブになったときのイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAbout_Deactivate(object sender, EventArgs e)
        {
            // フォームが非アクティブになったときにフォームを閉じる
            this.Close();
        }

        /// <summary>
        /// GitHubのURLがクリックされたときのイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLblGitUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // ブラウザでURLを開く
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = MyGitHubUrl, // リポジトリURL
                UseShellExecute = true
            });
        }

        #region アセンブリ属性アクセサー

        /////////////////////////////////////////////////////////////////
        /// 今後表示に使用する可能性もあるので未使用メソッドも残しておく
        /////////////////////////////////////////////////////////////////

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion


    }
}
