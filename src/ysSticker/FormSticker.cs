using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
        /// コンストラクタ
        /// </summary>
        public FormSticker()
        {
            InitializeComponent();

            // フォントとブラシの初期化
            // nullで描画に失敗するのを防止
            this._stickerFont = this.Font.Clone() as Font;
            this._stickerBrush = new SolidBrush(Color.White);

            // フォント、ブラシの設定
            this.SetStickerBrush();
            this.SetStickerFont();
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

        private void button1_Click(object sender, EventArgs e)
        {
            var a = this.DeviceDpi;
            MessageBox.Show(a.ToString());
            this.Close();
        }

        /// <summary>
        /// Paintイベント処理
        /// ステッカー文字表示イベント
        /// </summary>
        /// <param name="sender">イベント送信者</param>
        /// <param name="e">イベントデータ</param>
        private void FormSticker_Paint(object sender, PaintEventArgs e)
        {
            // 表示サイズ算出

            // フォームサイズ調整

            // テキスト表示
            e.Graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
            e.Graphics.DrawString("ステッカー", this._stickerFont, this._stickerBrush, new RectangleF(0, 0, 200, 200));
        }

        /// <summary>
        /// ステッカー文字のフォント設定を行う
        /// </summary>
        private void SetStickerFont()
        {
            // ディスプレイのDPI取得
            int devDpi = this.DeviceDpi;

            // フォントサイズをDPIに合わせて調整
            float fontsize = 100 * devDpi / 96.0f;

            ////////////////////////////////////////////////////////////////////////////
            // 更新タイミング時にフォントオブジェクトがない状況を防止するため、
            // 新しいフォントオブジェクトを作成、設定してから古いFontオブジェクトを破棄する
            ////////////////////////////////////////////////////////////////////////////

            // 新しいフォントオブジェクト作成
            Font newFont = new Font("Yu Gothic UI", fontsize, FontStyle.Bold);

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

            // 新しいブラシオブジェクト作成
            Brush newBrash = new SolidBrush(Color.Red);

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
