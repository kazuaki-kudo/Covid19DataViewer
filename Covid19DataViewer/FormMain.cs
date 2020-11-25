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

namespace Covid19DataViewer
{
    public partial class FormMain : Form
    {
        #region History
        /// <summary>
        /// ////////////////////////////////////////////////////////////////
        /// 2020/11/24 ver 1.0 DDT 工藤
        /// 初版
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
            this.Text = progName + " Ver." + version + " " + Copyright();

        }
        #endregion

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            buttonDownload.Enabled = false;
            buttonDownloadCancel.Enabled = true;

            //ダウンロードしたファイルの保存先
            string fileName = saveLocalFullPathConfirmed;
            //ダウンロード基のURL
            Uri u = new Uri(loadUrlConfirmed);

            //WebClientの作成
            if (downloadClient == null)
            {
                downloadClient = new System.Net.WebClient();
                downloadClient.Headers.Add();


                //イベントハンドラの作成
                downloadClient.DownloadProgressChanged +=
                    new System.Net.DownloadProgressChangedEventHandler(
                        downloadClient_DownloadProgressChanged);
                downloadClient.DownloadFileCompleted +=
                    new System.ComponentModel.AsyncCompletedEventHandler(
                        downloadClient_DownloadFileCompleted);
            }
            //非同期ダウンロードを開始する
            downloadClient.DownloadFileAsync(u, fileName);
        }

        private void buttonDownloadCancel_Click(object sender, EventArgs e)
        {
            //非同期ダウンロードをキャンセルする
            if (downloadClient != null)
            {
                downloadClient.CancelAsync();
            }
        }

        private void downloadClient_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            //Console.WriteLine("{0}% ({1}byte 中 {2}byte) ダウンロードが終了しました。",
            //    e.ProgressPercentage, e.TotalBytesToReceive, e.BytesReceived);
            string msg = string.Format("{0}% ({1}byte 中 {2}byte) ダウンロードが終了しました。",
                e.ProgressPercentage, e.TotalBytesToReceive, e.BytesReceived);
            SLogInv(msg);
        }

        private void downloadClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //Console.WriteLine("キャンセルされました。");
                SLogInv("キャンセルされました。");
            }
            else if (e.Error != null)
            {
                //Console.WriteLine("エラー:{0}", e.Error.Message);
                string msg = string.Format("エラー:{0}", e.Error.Message);
                SLogInv(msg);
            }
            else
            {
                //Console.WriteLine("ダウンロードが完了しました。");
                SLogInv("ダウンロードが完了しました。");
            }
            buttonDownload.Enabled = true;
            buttonDownloadCancel.Enabled = false;
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
    }
}
