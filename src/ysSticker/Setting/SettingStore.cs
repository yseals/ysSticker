using System;
using System.Drawing;

namespace ysSticker
{
    /// <summary>
    /// 設定データクラス
    /// </summary>
    public class SettingStore
    {
        /// <summary>
        /// デフォルトのフォント設定値
        /// </summary>
        private static readonly string DefaultFontString = "MS UI Gothic, 48pt";

        /// <summary>
        /// デフォルトの文字色設定値
        /// </summary>
        private static readonly Color DefaultFontColor = Color.Red;

        /// <summary>
        /// デフォルトの文字色設定値を文字列に変換した値
        /// </summary>
        private static readonly string DefaultFontColorString = new ColorConverter().ConvertToString(DefaultFontColor);

        /// <summary>
        /// ステッカー表示のフォントの文字列形式
        /// </summary>
        private string _displayTextFontString = DefaultFontString;

        /// <summary>
        /// ステッカー表示の文字色の文字列形式
        /// </summary>
        private string _displayTextColorString = DefaultFontColorString;

        /// <summary>
        /// 設定値をセットするメソッド
        /// </summary>
        /// <param name="ss">SettingStoreオブジェクト</param>
        public void SetSetting(SettingStore ss)
        {
            this.DisplayText = ss.DisplayText;
            this.DisplayTextFontString = ss.DisplayTextFontString;
            this.DisplayTextColorString = ss.DisplayTextColorString;
        }

        /// <summary>
        /// ステッカー表示テキスト
        /// </summary>
        public string DisplayText { get; set; } = "ysSticker\nSample Text";

        /// <summary>
        /// ステッカー表示フォントの文字列形式
        /// FontConverterで変換した文字列でセットする
        /// </summary>
        public string DisplayTextFontString
        {
            get
            {
                return _displayTextFontString;
            }
            set
            {
                // 変換可能か確認
                if (new FontConverter().IsValid(value) == false)
                {
                    // 変換できない場合は例外をスローする
                    throw new ArgumentException("無効な形式です", nameof(DisplayTextFontString));
                }
                this._displayTextFontString = value;
            }
        }

        /// <summary>
        /// ステッカー表示の文字色の文字列形式
        /// ColorConverterで変換した文字列でセットする
        /// </summary>
        public string DisplayTextColorString
        {
            get
            {
                return this._displayTextColorString;
            }
            set
            {
                // 変換可能か確認
                if (new ColorConverter().IsValid(value) == false)
                {
                    // 変換できない場合は例外をスローする
                    throw new ArgumentException("無効な形式です", nameof(DisplayTextColorString));
                }
                this._displayTextColorString = value;
            }
        }

        /// <summary>
        /// フォント文字列変換用のメソッド
        /// </summary>
        /// <param name="ft">フォントオブジェクト</param>
        /// <returns></returns>
        public string ConvertFontToString(Font ft)
        {
            try
            {
                // FontConverterを使用してFontオブジェクトを文字列に変換
                return new FontConverter().ConvertToString(ft);
            }
            catch
            {
                // 変換に失敗した場合は、例外をスルーする
                throw;
            }
        }

        /// <summary>
        /// カラー変換用のメソッド
        /// </summary>
        /// <param name="col">カラーオブジェクト</param>
        /// <returns></returns>
        public string ConvertColortToString(Color col)
        {
            try
            {
                // ColorConverterを使用してColorオブジェクトを文字列に変換
                return new ColorConverter().ConvertToString(col);
            }
            catch
            {
                // 変換に失敗した場合は、例外をスルーする
                throw;
            }
        }
    }
}
