using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StokDenekFormu
{
    public partial class UserControlSettings : System.Windows.Forms.UserControl
    {
        public UserControlSettings()
        {
            InitializeComponent();
            pnlShowSelectedColor.BackColor = this.BackColor;
            label1.Text = this.BackColor.Name;
            pnlForecolor.BackColor = this.ForeColor;
            label2.Text = this.ForeColor.Name;
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            //Show the color dialog and let the user choose a color
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //Write the value of the Color setting with the selected color
                Properties.Settings.Default.Color = colorDialog1.Color;
                //Save the settings
                Properties.Settings.Default.Save();
                //Display the new value of the Color setting on the panel
                pnlShowSelectedColor.BackColor = Properties.Settings.Default.Color;
                label1.Text = Properties.Settings.Default.Color.Name;
            }
        }

        private void btnForecolor_Click(object sender, EventArgs e)
        {
            //Show the color dialog and let the user choose a color
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //Write the value of the Color setting with the selected color
                Properties.Settings.Default.Color = colorDialog1.Color;
                //Save the settings
                Properties.Settings.Default.Save();
                //Display the new value of the Color setting on the panel
                pnlForecolor.BackColor = Properties.Settings.Default.Color;
                label2.Text = Properties.Settings.Default.Color.Name;

            }
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            // Persist the changes to the settings between application sessions
            Properties.Settings.Default.Save();
            MessageBox.Show("Ayarlar kaydedildi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Load the XML file from a file path
            XDocument xml = XDocument.Load(@"C:\Users\ümit\Desktop\Asp.Net Web Core\StokDenekFormu\StokDenekFormu\configuration.xml");
            // Query the XML elements using LINQ to XML

            var query = from elm in xml.Root.Elements()
                        select new
                        {
                            Name = elm.Element("fullname").Value,
                            Email = elm.Element("address").Value,
                            Topic = elm.Element("konu").Value
                        };
           // MessageBox.Show(query.GetType().ToString());
           // hatalı
            IEnumerable<string> strings = new List<string> { $"{tbFullname.Text ?? "null"}", $"{tbEmail.Text ?? "null"}", $"{tbKonu.Text ?? "null"}" };
            bool isSame = query.Any(x => x.Email == strings.ElementAt(1).ToString());
            if (isSame == false)
            {
                xml.Root.Add(new XElement("person",
                new XElement("fullname", strings.ElementAt(0)),
                new XElement("address", strings.ElementAt(1)),
                new XElement("konu", strings.ElementAt(2))
              ));
                xml.Save(@"C:\Users\ümit\Desktop\Asp.Net Web Core\StokDenekFormu\StokDenekFormu\configuration.xml");
                MessageBox.Show($"Name: {strings.ElementAt(0) ?? ""}, email: {strings.ElementAt(1) ?? ""}, konu: {strings.ElementAt(2) ?? ""}", "Kaydedilen Kullanıcı", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                tbEmail.Text = string.Empty;
                tbFullname.Text = string.Empty;
                tbKonu.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Kayıtlı kullanıcı","Uyarı",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
            }
            // Print the query results
            //foreach (var item in query)
            //{
            //    MessageBox.Show($"Name: {item.Name}, email: {item.Email}, konu: {item.Topic}");
            //}


        }
    }
}
