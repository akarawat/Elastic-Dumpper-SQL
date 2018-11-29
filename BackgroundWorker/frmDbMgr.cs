using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Data.SqlClient;

using System.Net;
using System.Web.UI;
using System.Web.Script.Serialization;

using System.Threading;
using System.Threading.Tasks;

namespace WorkerTest
{
    public partial class frmDbMgr : Form
    {
        public SqlConnection sqlConn;

        public frmDbMgr()
        {
            InitializeComponent();
        }
        //SCSLAB-PC\SQLEXPRESS|webaccess|Smartrac2015|BeethovenCellLine|view_lxs
        public bool DUMMPER;
        #region start DB
        public bool OpenConnection()
        {
            //string conStr = "Data Source=" + _SERV_M + ";Initial Catalog=" + _DB_M + ";Integrated Security=SSPI;User ID=" + _SA_M + ";Password=" + _PSW_M + ";";
            string conStr = "Server=" + txtSrv.Text.Trim() + ";Database=" + txtDb.Text.Trim() + ";User Id=" + txtLogin.Text.Trim() + ";Password=" + txtpass.Text.Trim() + ";";
            sqlConn = new SqlConnection(conStr);

            try
            {
                sqlConn.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Cannot Connect DB : " + ex.Message);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                sqlConn.Close();
                return true;
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion end DB
        private void btnTestConn_Click(object sender, EventArgs e)
        {
            if (txtQuery.Text == "" || txtView.Text == "" || txtDocNoSt.Text == "") return;
            lblRows.Text = "";
            Start();
            DUMMPER = false;
            //BgrdWorker.RunWorkerAsync();
            QueryFromDB();
        }
        private void QueryFromDB()
        {    
            if (OpenConnection())
            {
                string query = txtQuery.Text.Trim();
                if (OpenConnection() == true)
                {
                    string pathJson = @"json\" + txtView.Text + DateTime.Now.ToString("yyMMddHHmmss") + ".json";

                    if (DUMMPER && cbxJson.Checked)
                    {
                        File.Create(pathJson).Dispose();
                    }
                    try
                    {
                        if (File.Exists("DebugUID.txt") && chkDebug.Checked)
                        {
                            File.WriteAllText("DebugUID.txt", String.Empty);
                        }

                        SqlCommand cmd = new SqlCommand(query, sqlConn);
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        int numRows = dt.Rows.Count;
                        progressBar1.Style = ProgressBarStyle.Marquee;
                        progressBar1.Style = ProgressBarStyle.Continuous;
                        progressBar1.Maximum = numRows;
                        //progressBar1.Maximum = 1;
                        

                        int cont = 0;
                        int DocNo = Int32.Parse(txtDocNoSt.Text);

                        string[] urlarr = txtUrl.Text.Split('/');
                                                
                        string cmbUid;
                        foreach (DataRow row in dt.Rows)
                        {
                            cont++;
                            cmbUid = "";
                            //Cusref, SmartracBatch, ChipLot, IdentifierChip, IdentifierOS, IdentifierOSVersion, UID, BoxNr, status, teststatus, info1, info2, info3, info4, info5, ProductionDate, DateTime
                            //lvi.SubItems.Add(dataReader["COURSE_NAME"].ToString());
                            string txtRow = "";

                            string tUrlRw = txtUrl.Text + DocNo.ToString() + "/";

                            string tJsonRw = "{\"index\":{\"_index\":\""+ urlarr[3] + "\",\"_type\":\"" + urlarr[4] + "\",\"_id\":" + DocNo.ToString() + "}}";
                            if (cbxJson.Checked)
                            {
                                txtRow += tJsonRw + "\r\n";
                                txtRow += "{\"Cusref\": \"" + txtView.Text + "\",";
                            }
                            else
                            {
                                //txtRow = tUrlRw + "\n";
                                txtRow += "{\"Cusref\": \"" + txtView.Text + "\",";
                            }
                            
                            //txtRow = "{\"Cusref\": \"" + txtView.Text + "\",";
                            txtRow += " \"SmartracBatch\": \"" + row["SmartracBatch"].ToString() + "\",";
                            txtRow += " \"ChipLot\": \"" + row["ChipLot"].ToString() + "\",";
                            txtRow += " \"IdentifierChip\": \"" + row["IdentifierChip"].ToString() + "\", ";
                            txtRow += " \"IdentifierOS\": \"" + row["IdentifierOS"].ToString() + "\",";

                            txtRow += " \"IdentifierOSVersion\": \"" + row["IdentifierOSVersion"].ToString() + "\",";
                            
                            byte[] salt = (byte[])row["UID"];
                            string sUid;

                            int cZero = 0;
                            foreach (int arruid in salt)
                            {
                                sUid = arruid.ToString("x");

                                if (sUid == "0") { cZero++; }
                                else cZero = 0;
                                if (cZero >= 6) break;

                                if (sUid.Length == 1) sUid = "0" + sUid;
                                cmbUid += sUid.ToUpper();
                                
                                
                            }

                            //cmbUid = cmbUid.Substring(0, 34);

                            if (File.Exists("DebugUID.txt") && chkDebug.Checked)
                            {
                                StreamWriter w = File.AppendText("DebugUID.txt");
                                w.WriteLine("0x" + cmbUid);
                                w.Flush();
                                w.Close();
                            }

                            txtRow += " \"UID\": \"0x"+ cmbUid + "\",";
                            txtRow += " \"BoxNr\": \"" + row["BoxNr"].ToString() + "\",";
                            txtRow += " \"status\": " + row["status"].ToString() + ",";
                            txtRow += " \"teststatus\": " + row["teststatus"].ToString() + ",";
                            txtRow += " \"info1\": \"" + row["info1"].ToString() + "\",";
                            txtRow += " \"info2\": \"" + row["info2"].ToString() + "\",";
                            txtRow += " \"info3\": \"" + row["info3"].ToString() + "\",";
                            txtRow += " \"info4\": \"" + row["info4"].ToString() + "\",";
                            txtRow += " \"info5\": \"" + row["info5"].ToString() + "\",";

                            if (row["ProductionDate"].ToString() != "")
                            {
                                DateTime rowDt = (DateTime)row["ProductionDate"];
                                txtRow += " \"ProductionDate\": \"" + rowDt.ToString("yyyy-MM-dd") + "T" + rowDt.ToString("HH:mm:ss") + "Z" + "\",";
                            }
                            else
                            {
                                txtRow += " \"ProductionDate\": \"\",";
                            }

                            if (row["DateTime"].ToString() != "")
                            {
                                DateTime rowDt = (DateTime)row["DateTime"];
                                txtRow += " \"DateTime\": \"" + rowDt.ToString("yyyy-MM-dd") + "T" + rowDt.ToString("HH:mm:ss") + "Z" + "\"";
                            }
                            else
                            {
                                txtRow += " \"DateTime\": \"\"";
                            }
                            txtRow += "}";

                            progressBar1.Value = cont;
                            progressBar1.Refresh();
                            //SetText(tUrlRw + txtRow);
                            string txtShow = cont.ToString() + "|" + txtRow;
                            SetText(txtShow);
                            Application.DoEvents();
                            
                            if (DUMMPER)
                            {
                                if (cbxJson.Checked)
                                {
                                    // Json file Generate
                                    //string path = @"json\" + txtView.Text + ".json";
                                    if (File.Exists(pathJson) && cbxJson.Checked)
                                    {
                                        StreamWriter w = File.AppendText(pathJson);
                                        w.WriteLine(txtRow);
                                        w.Flush();
                                        w.Close();
                                    }
                                }
                                else
                                {
                                    DumpToElastic(tUrlRw, txtRow);
                                }
                                    
                            }
                                

                            //lblRows.Text = cont.ToString();
                            //AddMessage()
                            DocNo++;
                        }
                        CloseConnection();
                        
                        if (DUMMPER)
                        {
                            txtDocNoSt.Text = (DocNo).ToString();
                            WriteCounter(DocNo);

                            lblSucc.Text = "ElasticSerach Server update completed.";

                        }
                        //txtResText.Text = txtRow;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error analysing text file: " + ex.ToString());
                    }

                }
                
            }
            Stop();
        }
        private bool WriteCounter(int currow)
        {
            if (!File.Exists("counting.ini")) return false;
            StreamWriter txtfils = new StreamWriter("counting.ini");
            txtfils.Write(currow.ToString());
            txtfils.Close();
            return true;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        string ConvertStringArrayToString(string[] array)
        {
            //
            // Concatenate all the elements into a StringBuilder.
            //
            StringBuilder strinbuilder = new StringBuilder();
            foreach (string value in array)
            {
                strinbuilder.Append(value);
                strinbuilder.Append(' ');
            }
            return strinbuilder.ToString();
        }
        private void DumpToElastic(string tUrl, string tXml)
        {            
            //return;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(tUrl);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = tXml.Trim();
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
        private volatile bool _stopped = false;
        delegate void SetTextCallback(string text);
        private Thread AddThread = null;

        public void Start()
        {
            _stopped = false;
            this.AddThread = new Thread(new ThreadStart(this.DoWork));
            this.AddThread.Start();
        }
        private void DoWork()
        {
            while (!_stopped)
            {
                this.SetText("");
                //Thread.Sleep(1);
            }

        }
        private void SetText(string text)
        {
            if (this.lblRows.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else if (text != "")
            {
                string[] arr = text.Split('|');
                lblRows.Text = arr[0];
                txtResText.Text = arr[1];
            }
        }
        public void Stop()
        {
            _stopped = true;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (cbxJson.Checked)
            {
                MessageBox.Show("จะสร้างไฟล์ JSON แต่ไม่มีการ Import ผ่านทาง http");
            }
            if (MessageBox.Show("Confirm Insert to ElasticSearch", "Confirm !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (txtQuery.Text == "" || txtView.Text == "" || txtDocNoSt.Text == "") return;
                lblSucc.Text = "ElasticSerach Server updating...";
                DUMMPER = true;
                QueryFromDB();
            }
        }

        private void frmDbMgr_Load(object sender, EventArgs e)
        {
            GetConfig();
            GetCounter();
        }
        private bool GetConfig()
        {
            if (!File.Exists("DumpConfig.ini")) return false;
            TextReader tr = new StreamReader("DumpConfig.ini");
            string txtLine = tr.ReadLine();
            if (txtLine != null)
            {
                //SCSLAB-PC\SQLEXPRESS|webaccess|Smartrac2015|BeethovenCellLine|view_lxs
                string[] arrStr = txtLine.Split('|');
                txtSrv.Text = arrStr[0];
                txtLogin.Text = arrStr[1];
                txtpass.Text = arrStr[2];
                txtDb.Text = arrStr[3];
                txtView.Text = arrStr[4];
            }
            tr.Close();
            return true;
        }
        private bool GetCounter()
        {
            if (!File.Exists("counting.ini")) return false;
            TextReader tr = new StreamReader("counting.ini");
            string txtLine = tr.ReadLine();
            if (txtLine != null)
            {
                txtDocNoSt.Text = txtLine;
            }
            tr.Close();
            return true;
        }

        private void cbxJson_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
