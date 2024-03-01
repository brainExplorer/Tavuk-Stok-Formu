using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokDenekFormu
{
    public partial class UserControlProduct : System.Windows.Forms.UserControl
    {
        public UserControlProduct()
        {
            InitializeComponent();
         
        }
        private Veritabanı veritabanı = Veritabanı.GetInstance();
        private int getIndex { get; set; }

        private void UserControlProduct_Load(object sender, EventArgs e)
        {
            timer1.Start();

            if (dgvUrunler.DataSource != null)
            {
                dgvUrunler.Refresh();
            }
            dgvUrunler.ReadOnly = true;
           
            BindingSource source = new BindingSource();
            veritabanı.read("select * from Urunler");
            this.dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUrunler.AutoGenerateColumns = true;
            source.DataSource = veritabanı.dataTable;
            dgvUrunler.DataSource = source.List;
            CokSatanUrunler();
        }
        private void CokSatanUrunler()
        {
            try
            {
                if (dgvCokSatanlar.DataSource != null)
                {
                    dgvCokSatanlar.Refresh();
                }
                dgvCokSatanlar.ReadOnly = true;

                BindingSource source = new BindingSource();
                veritabanı.read("select Miktar from StokHareketleri where Miktar < 1000");
                this.dgvCokSatanlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCokSatanlar.AutoGenerateColumns = true;
                source.DataSource = veritabanı.dataTable;
                dgvCokSatanlar.DataSource = source.List;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", hata kaynağı " + ex.Source);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
               
                // formül deneme için oluşturuldu, gerekli halde değiştirilmelidir.
                decimal? satis = Convert.ToDecimal(tbSatisFiyati.Text);
                decimal alis = Convert.ToDecimal(tbAlisFiyati.Text);
                int? t_id = String.IsNullOrEmpty(cbUrunID.Text.ToString()) ? Convert.ToInt32(cbUrunID.Text) : Int32.MaxValue;
                String sorgu = $"insert into Urunler (UrunAdi, UrunKodu, Birim, AlisFiyati, SatisFiyati) " +
                    $"values ('{tbUrunAdi.Text}', '{tbUrunKodu.Text}', '{tbBirim.Text}', {alis}, {satis});";
                veritabanı.create(sorgu);
                veritabanı.dataTable.Rows.Clear();
              
                foreach (Control item in pnlStokHareketleri.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = String.Empty;
                    }
                }
                UserControlProduct_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ekleme Hatası");
            }
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                String dbString = "";
                dbString = $"delete from Urunler where UrunID = {Convert.ToInt32(cbUrunID.Text)};";
                veritabanı.delete(dbString);
                UserControlProduct_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            try
            {
                String dbString = "";
                string s_alis = String.IsNullOrEmpty(tbAlisFiyati.Text.Trim()) ? "0,00" : tbAlisFiyati.Text.Replace(',','.');
                string s_satis = String.IsNullOrEmpty(tbSatisFiyati.Text.Trim()) ? "0,00" : tbSatisFiyati.Text.Replace(',', '.');
                dbString = $"UPDATE Urunler SET UrunAdi = '{tbUrunAdi.Text}' ,UrunKodu = '{tbUrunKodu.Text}' ,Birim = '{tbBirim.Text}' ,AlisFiyati = {s_alis} ,SatisFiyati = {s_satis} WHERE UrunID = {cbUrunID.Text}";
                veritabanı.update(dbString);
                UserControlProduct_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUrunler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUrunler.Rows[e.RowIndex];
                getIndex = Convert.ToInt32(row.Cells[0].Value.ToString());
                cbUrunID.Text = getIndex.ToString();
                tbUrunAdi.Text = row.Cells[1].Value.ToString();
                tbUrunKodu.Text = row.Cells[2].Value.ToString();
                tbBirim.Text = row.Cells[3].Value.ToString();
                tbAlisFiyati.Text = row.Cells[4].Value.ToString();
                tbSatisFiyati.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
