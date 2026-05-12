using System;
using System.Windows.Forms;

namespace ysSticker
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ThreadExceptionイベントハンドラを追加
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            //ThreadExceptionが発生しないようにする
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
            //UnhandledExceptionイベントハンドラを追加
            System.AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new FormSticker());
            }
            catch
            {
                // エラーを握りつぶす 
            }
        }

        /// <summary>
        /// ThreadExceptionイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            // メッセージボックスを表示などもできないので、アプリケーションを終了するのみ
            Environment.Exit(1);
        }

        /// <summary>
        /// UnhandledExceptionイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // メッセージボックスを表示などもできないので、アプリケーションを終了するのみ
            Environment.Exit(1);
        }
    }
}
