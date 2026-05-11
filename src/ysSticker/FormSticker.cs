using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ysSticker
{
    /// <summary>
    /// ステッカー表示フォーム
    /// </summary>
    public partial class FormSticker : Form
    {
        /// <summary>
        /// ステッカー文字表示用のフォント
        /// </summary>
        private Font _stickerFont = null;

        /// <summary>
        /// ステッカー文字表示用のブラシ
        /// </summary>
        private Brush _stickerBrush = null;

        /// <summary>
        /// 設定ファイルオブジェクト
        /// </summary>
        private readonly SettingFile _settingFile = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormSticker()
        {
            InitializeComponent();

            try
            {
                // 設定ファイルオブジェクトの初期化
                this._settingFile = new SettingFile();

                // 設定ファイルが存在しない場合は、デフォルトの設定ファイルを作成する
                if (this._settingFile.IsExist() == false)
                {
                    MessageBox.Show("設定ファイルが見つかりませんでした。\nデフォルトの設定ファイルを作成します。", Application.ProductName + "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this._settingFile.CreateDefault();
                }

                // 設定ファイルの読み込み
                this._settingFile.Import();

                // 画面描画用オブジェクトの設定
                SetStickerPaintObject();
            }
            catch (Exception ex)
            {
                // 初期化に失敗した場合は、エラーメッセージを表示してフォームを閉じる
                MessageBox.Show("初期化に失敗しました。\nアプリケーションを終了します。\n" + ex.Message, Application.ProductName + "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        /// <summary>
        /// フォーム作成時のパラメータを設定する
        /// </summary>
        /// <remarks>
        /// アクティブ化を防止し、
        /// ウィンドウの下にあるウィンドウがマウスイベントを受け取ることができるようにし、
        /// ウィンドウをレイヤードウィンドウにするためのスタイルを設定する
        /// </remarks>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                // WS_EX_NOACTIVATE = 0x08000000 アクティブ化を防止する
                // WS_EX_TRANSPARENT = 0x00000020 ウィンドウの下にあるウィンドウが、マウスイベントを受け取ることができるようにする
                // WS_EX_LAYERED = 0x00080000 ウィンドウをレイヤードウィンドウにする
                cp.ExStyle |= 0x08000000 | 0x00000020 | 0x00080000;
                return cp;
            }
        }

        /// <summary>
        /// Paintイベント処理
        /// ステッカー文字表示イベント
        /// </summary>
        /// <param name="sender">イベント送信者</param>
        /// <param name="e">イベントデータ</param>
        private void FormSticker_Paint(object sender, PaintEventArgs e)
        {
            // 描画処理可能かチェック
            if (this.CanPaint() == false)
            {
                return;
            }

            // ステッカー表示テキスト取得
            string displayText = this._settingFile.Store.DisplayText;

            // TODO: 表示サイズ算出

            // TODO: フォームサイズ調整

            // テキスト表示
            e.Graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
            e.Graphics.DrawString(displayText, this._stickerFont, this._stickerBrush, new RectangleF(0, 0, 200, 200));
        }

        /// <summary>
        /// 描画処理を実行できるかどうかを判定します。
        /// </summary>
        /// <remarks>設定ファイル、フォント、またはブラシが未設定の場合はfalse</remarks>
        /// <returns>trueの場合は描画処理を実行できます。それ以外の場合はfalseです。</returns>
        private bool CanPaint()
        {
            if (this._settingFile == null)
            {
                // 設定ファイルがない場合は、描画処理を行わない
                return false;
            }

            // フォントとブラシのオブジェクトがない場合は、描画処理を行わない
            if (this._stickerFont == null || this._stickerBrush == null)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 画面描画用オブジェクトの設定を行う
        /// </summary>
        private void SetStickerPaintObject()
        {
            // フォントとブラシの設定
            this.SetStickerFont();
            this.SetStickerBrush();
        }

        /// <summary>
        /// ステッカー文字のフォント設定を行う
        /// </summary>
        private void SetStickerFont()
        {
            ////////////////////////////////////////////////////////////////////////////
            // 更新タイミング時にフォントオブジェクトがない状況を防止するため、
            // 新しいフォントオブジェクトを作成、設定してから古いFontオブジェクトを破棄する
            ////////////////////////////////////////////////////////////////////////////

            // 一時的なフォントオブジェクト作成
            string tfontFamilyName = string.Empty;
            FontStyle tfontStyle = FontStyle.Regular;
            float tfontSize = 0f;
            using (Font tmpFont = new FontConverter().ConvertFromString(this._settingFile.Store.DisplayTextFontString) as Font)
            {
                // フォントのプロパティ取得
                tfontFamilyName = tmpFont.FontFamily.Name;
                tfontStyle = tmpFont.Style;
                tfontSize = tmpFont.SizeInPoints;
            }

            // ディスプレイのDPI取得
            int devDpi = this.DeviceDpi;

            // フォントサイズをDPIに合わせて調整
            float fontsize = tfontSize * devDpi / 96.0f;

            // フォントサイズを調整した新しいフォントオブジェクト作成
            Font newFont = new Font(tfontFamilyName, fontsize, tfontStyle);

            // 古いフォントオブジェク退避し、新しいフォントオブジェクトを設定
            Font oldFont = this._stickerFont;
            this._stickerFont = newFont;

            // 古いフォントオブジェクトがある場合は破棄
            oldFont?.Dispose();
        }


        /// <summary>
        /// ステッカー文字のブラシ設定を行う
        /// </summary>
        private void SetStickerBrush()
        {
            ////////////////////////////////////////////////////////////////////////////
            // 更新タイミング時にブラシオブジェクトがない状況を防止するため、
            // 新しいブラシオブジェクトを作成、設定してから古いFontオブジェクトを破棄する
            ////////////////////////////////////////////////////////////////////////////

            Color col = (Color)new ColorConverter().ConvertFromString(this._settingFile.Store.DisplayTextColorString);

            // 新しいブラシオブジェクト作成
            Brush newBrash = new SolidBrush(col);

            // 古いブラシオブジェク退避し、新しいブラシオブジェクトを設定
            Brush oldBrash = this._stickerBrush;
            this._stickerBrush = newBrash;

            // 古いブラシオブジェクトある場合は破棄
            oldBrash?.Dispose();
        }

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // フォントとブラシのオブジェクトを破棄
                this._stickerFont?.Dispose();
                this._stickerFont = null;

                this._stickerBrush?.Dispose();
                this._stickerBrush = null;
            }

            // Formのコンポーネントを破棄
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
