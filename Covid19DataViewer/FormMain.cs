using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Covid19DataViewer
{
    public partial class FormMain : Form
    {
        #region History
        /// <summary>
        /// ////////////////////////////////////////////////////////////////
        /// 2020/11/24 ver 1.0
        /// 初版
        /// ////////////////////////////////////////////////////////////////
        /// 2020/11/25 ver -.-
        /// branch-test
        /// ////////////////////////////////////////////////////////////////
        /// </summary>
        private const string version = "1.0";
        private const string progName = "Covid19DataViewer";
        #endregion

        #region Common
        System.Net.WebClient downloadClient = null; // WebClientフィールド
        private const string saveLocalFullPathConfirmed = @"C:\Logs\time_series_19-covid-Confirmed.csv";
        private const string saveLocalFullPathDeaths = @"C:\Logs\time_series_19-covid-Deaths.csv";
        private const string saveLocalFullPathRecovered = @"C:\Logs\time_series_19-covid-Recovered.csv";
        private const string loadUrlConfirmed = @"https://github.com/CSSEGISandData/COVID-19/blob/master/csse_covid_19_data/csse_covid_19_time_series/time_series_covid19_confirmed_global.csv";
        private const string loadUrlDeathes = @"https://github.com/CSSEGISandData/COVID-19/blob/master/csse_covid_19_data/csse_covid_19_time_series/time_series_covid19_deaths_global.csv";
        private const string loadUrlRecovered = @"https://github.com/CSSEGISandData/COVID-19/blob/master/csse_covid_19_data/csse_covid_19_time_series/time_series_covid19_recovered_global.csv";
        DayData DataConfirmed;
        DayData DataDeaths;
        DayData DataRecovered;
        public enum CLMS
        {
            PROVINCE_STATE = 0,
            COUNTRY_REGION = 1,
            LATITUDE = 2,
            LONGTUDE = 3,
            DATETIME_AREA
        }
        #endregion

        #region Form
        public string Copyright()
        {
            string thisYear = DateTime.Now.Year.ToString();
            string cr = string.Format("Copyright (C) 2020 - {0}", thisYear);
            return cr;
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // バージョン表記
            string msg = progName + " Ver." + version;
            this.Text = msg + " " + Copyright();
            SLog(msg);

            // ディレクトリ表示前回値読み込み
            textBoxConfirmed.Text = Properties.Settings.Default.DirConfirmed;
            textBoxDeaths.Text = Properties.Settings.Default.DirDeaths;
            textBoxRecovered.Text = Properties.Settings.Default.DirRecovered;

            // データクラス初期化
            DataConfirmed = new DayData();
            DataDeaths = new DayData();
            DataRecovered = new DayData();
        }


        #endregion

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            //buttonDownload.Enabled = false;
            //buttonDownloadCancel.Enabled = true;

            ////ダウンロードしたファイルの保存先
            //string fileName = saveLocalFullPathConfirmed;
            ////ダウンロード基のURL
            //Uri u = new Uri(loadUrlConfirmed);

            ////WebClientの作成
            //if (downloadClient == null)
            //{
            //    downloadClient = new System.Net.WebClient();
            //    //downloadClient.Headers.Add();


            //    //イベントハンドラの作成
            //    downloadClient.DownloadProgressChanged +=
            //        new System.Net.DownloadProgressChangedEventHandler(
            //            downloadClient_DownloadProgressChanged);
            //    downloadClient.DownloadFileCompleted +=
            //        new System.ComponentModel.AsyncCompletedEventHandler(
            //            downloadClient_DownloadFileCompleted);
            //}
            ////非同期ダウンロードを開始する
            //downloadClient.DownloadFileAsync(u, fileName);
        }

        private void buttonDownloadCancel_Click(object sender, EventArgs e)
        {
            ////非同期ダウンロードをキャンセルする
            //if (downloadClient != null)
            //{
            //    downloadClient.CancelAsync();
            //}
        }

        private void downloadClient_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            //Console.WriteLine("{0}% ({1}byte 中 {2}byte) ダウンロードが終了しました。",
            //    e.ProgressPercentage, e.TotalBytesToReceive, e.BytesReceived);
            //string msg = string.Format("{0}% ({1}byte 中 {2}byte) ダウンロードが終了しました。",
            //    e.ProgressPercentage, e.TotalBytesToReceive, e.BytesReceived);
            //SLogInv(msg);
        }

        private void downloadClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            //if (e.Cancelled)
            //{
            //    //Console.WriteLine("キャンセルされました。");
            //    SLogInv("キャンセルされました。");
            //}
            //else if (e.Error != null)
            //{
            //    //Console.WriteLine("エラー:{0}", e.Error.Message);
            //    string msg = string.Format("エラー:{0}", e.Error.Message);
            //    SLogInv(msg);
            //}
            //else
            //{
            //    //Console.WriteLine("ダウンロードが完了しました。");
            //    SLogInv("ダウンロードが完了しました。");
            //}
            //buttonDownload.Enabled = true;
            //buttonDownloadCancel.Enabled = false;
        }

        #region 簡易ログ
        private void SLogAdust()
        {
            if (listBoxLog.Items.Count > 100)
            {
                // 表示量調整
                listBoxLog.Items.RemoveAt(0);
            }
            // 一番下までスクロールし、最後の項目を選択
            if (listBoxLog.Items.Count > 1)
            {
                listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
            }
            Application.DoEvents();
        }
        private void SLog(string text)
        {
            // 時刻
            DateTime dt = DateTime.Now;
            string time = dt.ToString("[hh:mm:ss] ");
            // 出力
            listBoxLog.Items.Add(time + text);
            SLogAdust();
        }
        private void SLogInv(string msg)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)(() => SLog(msg)));
            }
            else
            {
                SLog(msg);
            }
        }

        private void SLogDot()
        {
            int cnt = listBoxLog.Items.Count;
            string msg = string.Empty;
            if (cnt > 0)
            {
                msg = listBoxLog.Items[cnt - 1].ToString();
            }
            msg += '.';
            listBoxLog.Items[cnt - 1] = msg;
            Application.DoEvents();
        }

        //private double CountMax = 0;
        //private double CountLatest = 0;
        //private int CountIndex = 0;
        //private string CountFileName = string.Empty;
        //private string CountStr()
        //{
        //    return string.Format("{0} : {1} / {2}", CountFileName, CountLatest, CountMax);
        //}
        //private void SLogCountReset(double max, string fileName)
        //{
        //    CountMax = max;
        //    CountLatest = 0;
        //    CountFileName = fileName;
        //    // 時刻
        //    DateTime dt = DateTime.Now;
        //    string time = dt.ToString("[hh:mm:ss] ");
        //    // 出力
        //    CountIndex = listBoxLog.Items.Add(time + CountStr());
        //    SLogAdust();
        //}
        //private void SLogCountResetInv(double max, string fileName)
        //{
        //    if (this.InvokeRequired)
        //    {
        //        this.Invoke((MethodInvoker)(() => SLogCountReset(max, fileName)));
        //    }
        //    else
        //    {
        //        SLogCountReset(max, fileName);
        //    }
        //}

        //private void SlogCountUp()
        //{
        //    // カウント行クリアー
        //    if (listBoxLog.Items.Count < 0)
        //    {
        //        return;
        //    }
        //    listBoxLog.Items.RemoveAt(CountIndex);
        //    // 時刻
        //    DateTime dt = DateTime.Now;
        //    string time = dt.ToString("[hh:mm:ss] ");
        //    // 出力
        //    CountLatest++;
        //    CountIndex = listBoxLog.Items.Add(time + CountStr());
        //}
        //private void SlogCountUpInv()
        //{
        //    if (this.InvokeRequired)
        //    {
        //        this.Invoke((MethodInvoker)(() => SlogCountUp()));
        //    }
        //    else
        //    {
        //        SlogCountUp();
        //    }
        //}
        #endregion

        #region ReadFiles
        private void buttonConfirmed_Click(object sender, EventArgs e)
        {
            SelectFile(textBoxConfirmed, "Confirmed");
        }

        private void buttonDeaths_Click(object sender, EventArgs e)
        {
            SelectFile(textBoxDeaths, "Deaths");
        }

        private void buttonRecovered_Click(object sender, EventArgs e)
        {
            SelectFile(textBoxRecovered, "Recovered");
        }
        private void SelectFile(TextBox tBox, string fileType)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            // 初期フォルダー指定
            if (string.IsNullOrEmpty(tBox.Text))
            {
                ofDialog.InitialDirectory = @"C:\";
            }
            else
            {
                ofDialog.InitialDirectory = Path.GetDirectoryName(tBox.Text.Trim());
            }
            // ダイアログタイトル
            ofDialog.Title = string.Format("Choose the file ({0})", fileType);
            // ダイアログを表示する
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                tBox.Text = ofDialog.FileName;
            }
            // オブジェクトを破棄する
            ofDialog.Dispose();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            SLog("データを読み込みます");

            // ディレクトリ表示値保存
            Properties.Settings.Default.DirConfirmed = textBoxConfirmed.Text;
            Properties.Settings.Default.DirDeaths = textBoxDeaths.Text;
            Properties.Settings.Default.DirRecovered = textBoxRecovered.Text;
            Properties.Settings.Default.Save();

            // データクリアー
            DataConfirmed.Clear();
            DataDeaths.Clear();
            DataRecovered.Clear();



        }

        private void OpenFile(TextBox tBox, DayData dDat, string name)
        {
            string msg;
            string filePath = tBox.Text.Trim();
            // ファイルの有無確認
            if (!File.Exists(filePath))
            {
                // ファイルが存在しない
                msg = string.Format("ファイルが開けません ({0})", filePath);
                SLog(msg);
                MessageBox.Show(msg, name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // CSVファイルの読み込み
            try
            {
                using (StreamReader st = new StreamReader(filePath, Encoding.GetEncoding("UTF-8")))
                {
                    ReadFile(st, dDat, name);
                }
            }
            catch (IOException e)
            {
                msg = string.Format("ファイルを読み込めませんでした ({0})", e.Message.ToString());
                SLog(msg);
                MessageBox.Show(msg, name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private DateTime GetDateTimeData(string dt)
        {
            string[] strs = dt.Split('/');
            string month = string.Format("{0:00}",strs[0]);
            string day = string.Format("{0:00}",strs[1]);
            string year = "20" + strs[2];
            string strTime = string.Format("{0}/{1}/{2} 00:00:00", year, month, day);
            return DateTime.Parse(strTime);       
        }

        private void ReadFile(StreamReader st, DayData dDat, string name)
        {
            string msg;
            // CSVデータ読み込み
            msg = string.Format("データ読み込み ({0})", name);
            SLogInv(msg);
            bool Isfirst = true;
            List<DayData.Days> commonDaysList = new List<DayData.Days>();
            while (st.Peek() >= 0)
            {
                string[] cols = st.ReadLine().Split(',');
                // Header
                if (Isfirst)
                {
                    for (int c = (int)CLMS.DATETIME_AREA; c < cols.Length; c++)
                    {
                        DayData.Days ds = new DayData.Days();
                        ds.dayDt = GetDateTimeData(cols[c]);
                        ds.value = 0;
                        commonDaysList.Add(ds);
                    }
                    Isfirst = false;
                    continue;
                }
                // Data
                DayData.CSSEData cd = new DayData.CSSEData();
                cd.ProvinceState = cols[(int)CLMS.PROVINCE_STATE];
                cd.CountryRegion = cols[(int)CLMS.COUNTRY_REGION];
                cd.Latitude = short.Parse(cols[(int)CLMS.LATITUDE]);
                cd.Longtude = short.Parse(cols[(int)CLMS.LONGTUDE]);
                List<DayData.Days> daysList = new List<DayData.Days>();
                for (int c2 = (int)CLMS.DATETIME_AREA; c2 < cols.Length; c2++)
                {
                    DayData.Days ds2 = new DayData.Days();
                    ds2.dayDt = commonDaysList[c2 - (int)CLMS.DATETIME_AREA].dayDt;
                    ds2.value = int.Parse(cols[c2]);
                    daysList.Add(ds2);
                }
                cd.daysData = daysList;
                //dDat.Add(cd);
                SLogDot();
            }

            //Task<int> task = Task.Run(() => {

            //});
            //int result = await task;    // 0:成功 0以外:失敗
            //if (result == (int)ThreadResult.S_OK)
            //{
            //    SLog("sysconfigテーブル設定終了");
            //}
            return;
        }
        #endregion

    }
}
