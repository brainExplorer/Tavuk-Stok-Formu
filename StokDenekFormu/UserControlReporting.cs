
using iTextSharp.text;
using iTextSharp.text.pdf;
using MailKit.Security;
using MimeKit;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Mail;
using MailKit.Net.Smtp;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using System.Globalization;


namespace StokDenekFormu
{
    public partial class UserControlReporting : System.Windows.Forms.UserControl
    {
        private Veritabanı veritabanı = Veritabanı.GetInstance();
        public UserControlReporting()
        {
            InitializeComponent();
        }
        public string filename { get; set; }
        private string _queryString {  get; set; }
        private void UserControlReporting_Load(object sender, EventArgs e)
        {
            // döviz verileri
            timer1.Start();
            ParaBirimleri();


            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-670IFMK\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    System.Data.DataSet ds = new System.Data.DataSet();
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                       _queryString = String.IsNullOrEmpty(_queryString) ? "select UrunAdi, AlisFiyati from Urunler" : _queryString;
                        cmd.CommandText = _queryString;
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        DataTable ChartData = ds.Tables[0];
                        //storing total rows count to loop on each Record                          
                        string[] XPoints = new string[ChartData.Rows.Count];
                        int[] YPOints = new int[ChartData.Rows.Count];
                        for (int count = 0; count < ChartData.Rows.Count; count++)
                        {
                            // store values for X axis  
                            XPoints[count] = ChartData.Rows[count]["UrunAdi"].ToString();
                            //store values for Y Axis  
                            YPOints[count] = Convert.ToInt32(ChartData.Rows[count]["AlisFiyati"]);
                        }

                        //binding chart control  
                        chartAlisFiyati.Series[0].Points.DataBindXY(XPoints, YPOints);
                        chartAlisFiyati.Series[0].Label = "#PERCENT{P0}";
                        //chartRapor.Series[0].BorderWidth = 2;
                        //chartRapor.Series[0].BorderColor = Color.White;
                        ////setting Chart type   
                        chartAlisFiyati.Series[0].ChartType = SeriesChartType.Doughnut;
                        //enable to show legend
                        chartAlisFiyati.Series[0].LegendText = "#VALX";
                        chartAlisFiyati.Legends[0].Enabled = true;
                        chartAlisFiyati.Titles.Add("Alış Fiyatı");
                        //show chart in 3d
                        //chartRapor.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
                    }
                    _queryString = String.Empty;
                }
                using (SqlCommand cmd = new SqlCommand())
                {
                    System.Data.DataSet ds = new System.Data.DataSet();
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        _queryString = String.IsNullOrEmpty(_queryString) ? "select UrunAdi, SatisFiyati from Urunler" : _queryString;
                        cmd.CommandText = _queryString;
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(ds);
                        DataTable ChartData = ds.Tables[0];
                        //storing total rows count to loop on each Record                          
                        string[] XPoints = new string[ChartData.Rows.Count];
                        int[] YPOints = new int[ChartData.Rows.Count];
                        for (int count = 0; count < ChartData.Rows.Count; count++)
                        {
                            // store values for X axis  
                            XPoints[count] = ChartData.Rows[count]["UrunAdi"].ToString();
                            //store values for Y Axis  
                            YPOints[count] = Convert.ToInt32(ChartData.Rows[count]["SatisFiyati"]);
                        }

                        //binding chart control  
                        chartSatisFiyati.Series[0].Points.DataBindXY(XPoints, YPOints);
                        chartSatisFiyati.Series[0].Label = "#PERCENT{P0}";
                        //chartRapor.Series[0].BorderWidth = 2;
                        //chartRapor.Series[0].BorderColor = Color.White;
                        ////setting Chart type   
                        chartSatisFiyati.Series[0].ChartType = SeriesChartType.Doughnut;
                        //enable to show legend
                        chartSatisFiyati.Series[0].LegendText = "#VALX";
                        chartSatisFiyati.Legends[0].Enabled = true;
                        chartSatisFiyati.Titles.Add("Satış Fiyatı");
                        //show chart in 3d
                        //chartRapor.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
                        
                    }
                    _queryString = String.Empty;

                }
            }
        }

        public void ParaBirimleri()
        {
            try
            {
                XmlDocument xmlVerisi = new XmlDocument();
                xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

                decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
                decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
                decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ','));
                decimal japonYeni = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "JPY")).InnerText.Replace('.', ','));

                lbDolar.Text = dolar.ToString("C", new CultureInfo("en-US"));
                lbEuro.Text = euro.ToString("C", new CultureInfo("de-DE"));
                lbSterlin.Text = sterlin.ToString("C", new CultureInfo("en-GB"));
                lbYen.Text = japonYeni.ToString("C", new CultureInfo("ja-JP"));
            }
            catch (XmlException xml)
            {
                timer1.Stop();
                MessageBox.Show(xml.ToString());
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           SaveAsPdf();
            MessageBox.Show($"{filename} adlı belge kaydedildi.", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SaveAsPdf();
            FormEmailList formEmailList = new FormEmailList();
            formEmailList.ShowDialog();
            // Create a new MailMessage object
            SendEmailAsync(filename,formEmailList.SelectedEmailAddress);
            MessageBox.Show($"{formEmailList.SelectedEmailAddress} kişisine {filename} adlı belge gönderildi.", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


        }
        public void SendEmailAsync(string filename, string toEmail)
        {

            if (toEmail.Contains("*.gmail"))
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Ümit Yavuz", toEmail));
                message.To.Add(new MailboxAddress("Recipient", toEmail));
                message.Subject = "Hello from C# with OAuth2!";
                message.Body = new TextPart("plain") { Text = "This is the email body." };

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    client.Authenticate("your.email@gmail.com", "access_token_here"); // Use the access token
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            try
            {
                //string to = "megafalkon@hotmail.com";
                string subject = "Rapor";
                string body = "Rapor içeriği ektedir.";

                string email = "megafalkon@hotmail.com";
                string passw = "şifreni buraya yaz";
                string host = "smtp.office365.com";
                int port = 587;

                Attachment attachment = new Attachment(filename);
                using (MailMessage mail = new MailMessage(email, toEmail, subject, body))
                {
                    mail.Attachments.Add(attachment);
                    using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient(host, port))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential(email, passw);
                        smtp.Send(mail);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void Smtp_SendCompleted1(object sender, AsyncCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Smtp_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void SaveAsPdf()
        {

            try
            {
                // Create path
                string userName = Environment.UserName;
                string specializedFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                // Create unique filename
                string randomFileName = Guid.NewGuid().ToString();
                string combineFilePath = Path.Combine(userName, specializedFolderPath, randomFileName);
                filename = $"{combineFilePath}.pdf";
                FileStream fs = new FileStream(filename, FileMode.CreateNew);
                Document doc = new Document(PageSize.A4);
                PdfWriter pdfWriter = PdfWriter.GetInstance(doc, fs);

                doc.Open();
                PdfContentByte cb = pdfWriter.DirectContent;
                Veritabanı veritabanı = Veritabanı.GetInstance();
                veritabanı.read("select * from Urunler");
                for (int i = 0; i < veritabanı.dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < veritabanı.dataTable.Columns.Count; j++)
                    {
                        doc.Add(new iTextSharp.text.Paragraph(veritabanı.dataTable.Rows[i][j].ToString())); // Replace with your actual data
                    }
                }
                pdfWriter.CloseStream = true;
                doc.Close();
                fs.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            ParaBirimleri();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xmlVerisi = new XmlDocument();
                xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

                decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','))*Convert.ToDecimal(tbTlDegeri.Text);
                decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ',')) * Convert.ToDecimal(tbTlDegeri.Text);
                decimal sterlin = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ',')) * Convert.ToDecimal(tbTlDegeri.Text);
                decimal japonYeni = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "JPY")).InnerText.Replace('.', ','))*Convert.ToDecimal(tbTlDegeri.Text);

                tbLbDolar.Text = dolar.ToString("C", new CultureInfo("en-US"));
                tbLbeuro.Text = euro.ToString("C", new CultureInfo("de-DE"));
                tbLbSterlin.Text = sterlin.ToString("C", new CultureInfo("en-GB"));
                tbLbYen.Text = japonYeni.ToString("C", new CultureInfo("ja-JP"));
            }
            catch (XmlException xml)
            {
                timer1.Stop();
                MessageBox.Show(xml.ToString());
            }
        }

        private void tbTlDegeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Prevent non-numeric input
                MessageBox.Show("Sadece sayı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Allow only one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}