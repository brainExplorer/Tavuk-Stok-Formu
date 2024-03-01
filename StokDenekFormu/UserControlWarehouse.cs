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
    public partial class UserControlWarehouse : System.Windows.Forms.UserControl
    {
        public UserControlWarehouse()
        {
            InitializeComponent();
        }
        private Veritabanı veritabanı = Veritabanı.GetInstance();

        private int getIndex { get; set; }

        private void UserControlWarehouse_Load(object sender, EventArgs e)
        {
            if (dgvDepolar.DataSource != null)
            {
                dgvDepolar.Refresh();
            }
            dgvDepolar.ReadOnly = true;

            BindingSource source = new BindingSource();
            veritabanı.read("select * from Depolar");
            this.dgvDepolar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepolar.AutoGenerateColumns = true;
            source.DataSource = veritabanı.dataTable;
            dgvDepolar.DataSource = source.List;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                String sorgu = $"insert into Depolar( DepoAdi, Adres) " +
                    $"values ('{tbDepoAdı.Text}', '{tbDepoAdres.Text}');";
                veritabanı.create(sorgu);
                veritabanı.dataTable.Rows.Clear();
                UserControlWarehouse_Load(sender, e);
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
                int t_id = int.TryParse(tbDepoID.Text, out t_id) ? t_id : 0;
                String sorgu = $"delete from Depolar where DepoID = {t_id};";
                veritabanı.create(sorgu);
                veritabanı.dataTable.Rows.Clear();
                UserControlWarehouse_Load(sender, e);
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
                int t_id = int.TryParse(tbDepoID.Text, out t_id) ? t_id : 0;

                String dbString = "";
                dbString = $"update Depolar set DepoAdi = '{tbDepoAdı.Text}', Adres = '{tbDepoAdres.Text}' where DepoID = {t_id};";
                veritabanı.update(dbString);
                UserControlWarehouse_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDepolar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDepolar.Rows[e.RowIndex];
                getIndex = Convert.ToInt32(row.Cells[0].Value.ToString());
                tbDepoID.Text = getIndex.ToString();
                tbDepoAdı.Text = row.Cells[1].Value.ToString();
                tbDepoAdres.Text = row.Cells[2].Value.ToString();
          
            }
        }
    }
}
