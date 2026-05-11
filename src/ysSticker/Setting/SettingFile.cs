using System;
using System.IO;
using System.Text.Json;

namespace ysSticker
{
    internal class SettingFile
    {
        /// <summary>
        /// 設定ファイルのファイルパス
        /// </summary>
        public string FilePath { get; private set; } = string.Empty;

        /// <summary>
        /// SettingFile クラスの新しいインスタンスを初期化します。
        /// ファイルパスはデフォルト指定で "setting.json" になります。
        /// </summary>
        public SettingFile()
        {
            // デフォルトのファイルパスを設定
            this.FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");
        }

        /// <summary>
        /// 指定されたファイルパスを使用して、SettingFile クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="filePath">設定ファイルのフルパス。</param>
        public SettingFile(string filePath)
            : this()
        {
            this.FilePath = filePath;
        }

        /// <summary>
        /// 設定ファイルオブジェクト
        /// </summary>
        public SettingStore Store { get; private set; } = new SettingStore();

        /// <summary>
        /// 設定ファイル読み込み
        /// </summary>
        public void Import()
        {
            if(this.IsExist() == false)
            {
                throw new FileNotFoundException("設定ファイルが見つかりません。", this.FilePath);
            }

            try
            {
                // 設定ファイルを読み込みデシリアライズ
                string json = File.ReadAllText(this.FilePath);
                var readStore = JsonSerializer.Deserialize<SettingStore>(json);
                this.Store.SetSetting(readStore);
            }
            catch
            {
                // ファイルが壊れている等の場合はエラー
                throw;
            }
        }

        /// <summary>
        /// 設定ファイル書き込み
        /// </summary>
        public void Export()
        {
            // ディレクトリが存在しない場合は作成する
            if (Directory.Exists(this.FilePath) == false)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(this.FilePath));
            }

            // 設定ファイルを JSON 形式で保存する
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(this.Store, options);
            File.WriteAllText(this.FilePath, json);
        }

        /// <summary>
        /// 設定ファイルの存在確認
        /// </summary>
        /// <returns>設定ファイルが存在する場合は true、存在しない場合は false を返します。</returns>
        public bool IsExist()
        {
            // 設定ファイルが存在するか確認する
            if (File.Exists(this.FilePath) == false)
            {
                // ファイルが存在しない場合は false を返す
                return false;
            }

            return true;
        }

        /// <summary>
        /// デフォルトの設定ファイルの作成
        /// </summary>
        public void CreateDefault()
        {
            // デフォルトの設定値をエクスポートする
            this.Export();
        }
    }
}
