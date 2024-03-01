using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StokDenekFormu
{
    public partial class FormEmailList : Form
    {
        public FormEmailList()
        {
            InitializeComponent();
        }
        public string SelectedEmailAddress { get; set; }
        private void FormEmailList_Load(object sender, EventArgs e)
        {
           AddElementsToList();
        }
        public void AddElementsToList()
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
            foreach (var item in query)
            {
               lvEmailListesi.Items.Add(item.Email);
            }
        }
        private void btnSec_Click(object sender, EventArgs e)
        {
            if (lvEmailListesi.SelectedItems.Count != 1 )
            {
                MessageBox.Show("Lütfen bir tane email seçin.", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                SelectedEmailAddress = lvEmailListesi.SelectedItems[0].Text;
                this.Close();
            }
        }
    }
}
