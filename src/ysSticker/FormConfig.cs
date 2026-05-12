using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ysSticker
{
    public partial class FormConfig : Form
    {
        /// <summary>
        /// 設定ファイルオブジェクト
        /// </summary>
        private readonly SettingFile _settingFile;

        /// <summary>
        /// サンプル表示のフォントオブジェクト
        /// </summary>
        private Font _displaySampleFont = null;

        public FormConfig(SettingFile settingFile)
        {
            InitializeComponent();

            this._settingFile = settingFile;
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            // 設定の初期値を設定
            this.txtDisplayText.Text = this._settingFile.Store.DisplayText;
            this.txtDisplayFont.Text = this._settingFile.Store.DisplayTextFontString;
            this.txtDisplayColor.Text = string.Empty;
            this.txtDisplayColor.BackColor = (Color)new ColorConverter().ConvertFromString(this._settingFile.Store.DisplayTextColorString);

            // サンプル表示用のフォントオブジェクトを作成
            this._displaySampleFont = (Font)new FontConverter().ConvertFromString(this._settingFile.Store.DisplayTextFontString);

            // サンプル表示用のフォントオブジェクト１度セットし、以降はUpdateSampleViewで更新時に
            // Fontオブジェクト破棄してから新しいFontオブジェクトを作成、設定するようにする
            // システムのフォントをDispose防止の対策
            this.lblDisplaySambleView.Font = this._displaySampleFont;

            // サンプル表示を更新
            UpdateSampleView();
        }

        /// <summary>
        /// サンプル表示を更新
        /// </summary>
        private void UpdateSampleView()
        {
            // 表示テキストの変化があれば更新する
            if(this.lblDisplayText.Text != this.lblDisplaySambleView.Text)
            {
                this.lblDisplaySambleView.Text = this.txtDisplayText.Text;
            }

            // 表示フォントの変更があれば更新する
            if(this.txtDisplayFont.Text != new FontConverter().ConvertToString(this._displaySampleFont))
            {
                // フォントオブジェクトを破棄してから新しいFontオブジェクトを作成、設定する
                using (Font oldFont = this.lblDisplaySambleView.Font)
                {
                    Font newFont = (Font)new FontConverter().ConvertFromString(this.txtDisplayFont.Text);
                    this.lblDisplaySambleView.Font = newFont;
                    this._displaySampleFont = newFont;
                }
            }

            // 表示色の変更があれば更新する
            if(this.txtDisplayColor.BackColor != this.lblDisplaySambleView.ForeColor)
            {
                this.lblDisplaySambleView.ForeColor = this.txtDisplayColor.BackColor;
            }
        }

        /// <summary>
        /// 設定ボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 一時的な設定ファイルオブジェクト
            // 設定エラー発生時にもとに戻せるように、設定ファイルオブジェクトに直接設定しないようにする
            // SettingStoreのSet処理に簡易的なバリデーションを入れているため、例外が発生する可能性がある
            SettingStore tmpSetting = new SettingStore();

            try
            {
                // 表示文字を設定
                tmpSetting.DisplayText = this.txtDisplayText.Text;
            }
            catch(Exception)
            {
                MessageBox.Show("表示文字の設定値の保存に失敗しました。", Application.ProductName + "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // フォントを設定
                tmpSetting.DisplayTextFontString = this.txtDisplayFont.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("フォントの設定値の保存に失敗しました。", Application.ProductName + "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 色を設定
                tmpSetting.DisplayTextColorString = new ColorConverter().ConvertToString(this.txtDisplayColor.BackColor);
            }
            catch (Exception)
            {
                MessageBox.Show("色の設定値の保存に失敗しました。", Application.ProductName + "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 設定ファイルオブジェクトに一時的な設定ファイルオブジェクトの値を設定
            this._settingFile.Store.SetSetting(tmpSetting);

            // 設定ファイルへ設定値を保存
            this._settingFile.Export();
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// キャンセルボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        /// <summary>
        /// フォント選択ボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFontSelect_Click(object sender, EventArgs e)
        {
            // フォントダイアログに現在のフォントを設定
            using (Font tmpFont = (Font)new FontConverter().ConvertFromString(this.txtDisplayFont.Text))
            {
                fontDialogObj.Font = tmpFont;

                // フォントダイアログを表示
                if (fontDialogObj.ShowDialog() == DialogResult.OK)
                {
                    // フォントダイアログで選択されたフォントをテキストボックスに表示
                    using (Font selectedFont = fontDialogObj.Font)
                    {
                        this.txtDisplayFont.Text = new FontConverter().ConvertToString(selectedFont);
                    }
                }
            }

            // サンプル表示を更新
            UpdateSampleView();
        }

        /// <summary>
        /// 色選択ボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColorSelect_Click(object sender, EventArgs e)
        {
            // 色ダイアログに現在の色を設定
            colorDialogObj.Color = this.txtDisplayColor.BackColor;
            colorDialogObj.FullOpen = true;

            // 色ダイアログを表示
            if (colorDialogObj.ShowDialog() == DialogResult.OK)
            {
                // 色ダイアログで選択された色をラベルの背景色に設定し、選択された色の文字列をラベルに表示
                this.txtDisplayColor.BackColor = colorDialogObj.Color;
            }

            // サンプル表示を更新
            UpdateSampleView();
        }

        /// <summary>
        /// 表示文字変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDisplayText_TextChanged(object sender, EventArgs e)
        {
            // サンプル表示を更新
            UpdateSampleView();
        }
    }
}
