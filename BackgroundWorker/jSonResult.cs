using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Net;
using System.Web.UI;
using System.Web.Script.Serialization;

namespace WorkerTest
{
    public partial class jSonResult : Form
    {
        public jSonResult()
        {
            InitializeComponent();
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            GetFromElastic(txtUrl.Text);
        }
        private void GetFromElastic(string tUrl)
        {
            //return;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(tUrl);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            //{
            //    string json = tXml.Trim();
            //    streamWriter.Write(json);
            //    streamWriter.Flush();
            //    streamWriter.Close();
            //}
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                if (chkDebug.Checked)
                {
                    if (File.Exists("DebugJson.txt") && chkDebug.Checked)
                    {
                        File.WriteAllText("DebugJson.txt", String.Empty);
                    }
                    if (File.Exists("DebugJson.txt") && chkDebug.Checked)
                    {
                        StreamWriter w = File.AppendText("DebugJson.txt");
                        w.WriteLine(result);
                        w.Flush();
                        w.Close();
                    }
                }
                if(chkTxt.Checked) txtJsonRes.Text = result;
            }            
        }
    }
}
