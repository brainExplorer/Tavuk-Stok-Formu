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
using System.Xml.Linq;

namespace StokDenekFormu
{
    public partial class UserControlSupplier : System.Windows.Forms.UserControl
    {
        public UserControlSupplier()
        {
            InitializeComponent();
        }

        private Veritabanı veritabanı = Veritabanı.GetInstance();
        private int getIndex { get; set; }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // email adresinin doğruluk kontrolü
                string email = tbEmail.Text;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (!match.Success)
                    MessageBox.Show("Email adresi geçerli değil tekrar deneyiniz");

                String sorgu = $"insert into Tedarikciler( TedarikciAdi, Telefon, Email) " +
                    $"values ('{tbTedarikciAdi.Text}', '{tbTelefon.Text}', '{tbEmail.Text}');";
                veritabanı.create(sorgu);
                UserControlSupplier_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserControlSupplier_Load(object sender, EventArgs e)
        {
            dgvTedarikciler.ReadOnly = true;
            BindingSource source = new BindingSource();
            veritabanı.read("select * from Tedarikciler");
            this.dgvTedarikciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTedarikciler.AutoGenerateColumns = true;
            source.DataSource = veritabanı.dataTable;
            dgvTedarikciler.DataSource = source.List;
        
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                String dbString = "";
                dbString = $"delete from Tedarikciler where TedarikciID = {getIndex};";
                veritabanı.delete(dbString);
                UserControlSupplier_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                String dbString = "";
                dbString = $"update Tedarikciler set TedarikciAdi = '{tbTedarikciAdi.Text}', Telefon = '{tbTelefon.Text}', Email = '{tbEmail.Text}'  where TedarikciID = {getIndex};";
                veritabanı.update(dbString);
                UserControlSupplier_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTedarikciler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTedarikciler.Rows[e.RowIndex];
                getIndex = Convert.ToInt32(row.Cells[0].Value.ToString());
                tbTedarikciAdi.Text = row.Cells[1].Value.ToString();
                tbTelefon.Text = row.Cells[2].Value.ToString();
                tbEmail.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvTedarikciler.ReadOnly = true;
            BindingSource source = new BindingSource();
            int id = int.TryParse(tbSearch.Text, out id) ? id : 0;
            veritabanı.read($"select * from Tedarikciler where TedarikciID = {id} or TedarikciAdi like '%{tbSearch.Text.ToString()}%'");
            this.dgvTedarikciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTedarikciler.AutoGenerateColumns = true;
            source.DataSource = veritabanı.dataTable;
            dgvTedarikciler.DataSource = source.List;

            /*
             * DataSource verilerini okumak için yazıldı
            */
            //DataRowView current = (DataRowView)source.Current;
            //MessageBox.Show(current.Row[1].ToString());

        }
    }
}
