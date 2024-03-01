using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokDenekFormu
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private Veritabanı veritabanı = Veritabanı.GetInstance();
        private void btnLoginpage_Click(object sender, EventArgs e)
        {
            string[] credentials = { tbKullaniciAdi.Text ?? "", tbSifre.Text ?? ""};
            
            if (veritabanı.kullaniciSorgusu(credentials[0], credentials[1]))
            {
                this.Hide();
                FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
                frmAnaSayfa.ShowDialog();
                this.Close();
            }
        }
    }
}
