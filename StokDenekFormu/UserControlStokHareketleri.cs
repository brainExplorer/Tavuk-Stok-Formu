using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokDenekFormu
{
    public partial class UserControlStokHareketleri : System.Windows.Forms.UserControl
    {
        private int getIndex { get; set; }
        private Veritabanı veritabanı = Veritabanı.GetInstance();
        public UserControlStokHareketleri()
        {
            InitializeComponent();

        }

        private void UserControlStokHareketleri_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dgvStokHareketleri.ReadOnly = true;
            BindingSource source = new BindingSource();
            veritabanı.read("select * from StokHareketleri");
            this.dgvStokHareketleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStokHareketleri.AutoGenerateColumns = true;
            source.DataSource = veritabanı.dataTable;
            dgvStokHareketleri.DataSource = source.List;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void dgvStokHareketleri_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStokHareketleri.Rows[e.RowIndex];
                getIndex = Convert.ToInt32(row.Cells[0].Value.ToString());
                cbHareketID.Text = getIndex.ToString();
                cbUrunID.Text = Convert.ToString(row.Cells[1].Value.ToString());
                cbDepoID.Text = Convert.ToString(row.Cells[2].Value.ToString());
                cbTedarikciID.Text = Convert.ToString(row.Cells[3].Value.ToString());
                dtpHareketTarihi.Text = Convert.ToString(row.Cells[4].Value.ToString());
                tbMiktar.Text = Convert.ToString(row.Cells[5].Value.ToString());
                tbHareketTuru.Text = Convert.ToString(row.Cells[6].Value.ToString());
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string dateTime = DateTime.Now.ToString("yyyy - MM - dd");
                MessageBox.Show(dateTime.ToString());
                // çalışmıyor
                //String sorgu = $"insert into StokHareketleri( UrunID, DepoID, TedarikciID, HareketTarihi, Miktar, HareketTuru) " +
                //    $"values ((Select UrunID from Urunler where UrunID = {cbUrunID.Text}), " +
                //    $"(select DepoID from Depolar where depoID = {cbDepoID.Text})," +
                //    $" (select TedarikciID from Tedarikciler where TedarikciID = {cbTedarikciID.Text})," +
                //    $" '{dateTime}', {tbMiktar.Text}, '{tbHareketTuru.Text}'";
                 string sorgu = $"INSERT INTO Stokhareketleri( UrunID, DepoID, TedarikciID, HareketTarihi, Miktar, HareketTuru) VALUES ({cbUrunID.Text}, {cbDepoID.Text}, {cbTedarikciID.Text}, '{dateTime}', {tbMiktar.Text}, '{tbHareketTuru.Text}')";
                veritabanı.create(sorgu);
                UserControlStokHareketleri_Load(sender, e);
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
                string dateTime = DateTime.Now.ToString("yyyy - MM - dd");
                dbString = $"update StokHareketleri set UrunID = {cbUrunID.Text}, DepoID = {cbDepoID.Text}, TedarikciID = {cbTedarikciID.Text}, HareketTarihi = '{dateTime}', Miktar = {tbMiktar.Text}, HareketTuru = '{tbHareketTuru.Text}'  where HareketID = {cbHareketID.Text};";
                veritabanı.update(dbString);
                UserControlStokHareketleri_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                String dbString = "";
                dbString = $"delete from StokHareketleri where HareketID = {getIndex};";
                veritabanı.delete(dbString);
                UserControlStokHareketleri_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
