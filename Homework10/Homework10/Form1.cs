using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

namespace Homework10
{
    public partial class Form1 : Form
    {
        BindingSource bindingsource = new BindingSource();
        Crawler crawler = new Crawler();
        Thread thread = null;
        public Form1()
        {
            InitializeComponent();
            DataGridView.DataSource = bindingsource;
            crawler.HtmlDownload += Crawler_PageDownloaded;
            crawler.CrawlerStop += Crawler_CrawlerStopped;
        }

        private void Crawler_CrawlerStopped(Crawler crawler)
        {
            Action action = () => Label.Text = "爬虫已停止";
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Crawler_PageDownloaded(Crawler crawler, int index,string url, string status)
        {
            var Info = new { Index = index, Url = url, Status = status };
            Action action = () => bindingsource.Add(Info);
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            bindingsource.Clear();
            crawler.StartURL = TextBox.Text;

            Match match = Regex.Match(crawler.StartURL, Crawler.urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            crawler.HostFilter = "^" + host + "$";
            crawler.FileFilter = ".html?$";

            if (thread != null)
            {
                thread.Abort();
            }
            thread = new Thread(crawler.Start);
            thread.Start();
            Label.Text = "爬虫已启动....";
        }
    }
}
