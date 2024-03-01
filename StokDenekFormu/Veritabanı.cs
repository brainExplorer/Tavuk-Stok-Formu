using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StokDenekFormu
{
     public sealed class Veritabanı
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection con;
        public string sorgu { get; set; }
        public DataTable dataTable = null;
        private static Veritabanı _instance;
        private Veritabanı()
        {
            con = new SqlConnection("Data Source=DESKTOP-670IFMK\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True");
        }

        public static Veritabanı GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Veritabanı();
            }
            return _instance;
        }
        public void create(string item)
        {
            if ( con.State  == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                cmd = new SqlCommand(item, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sorgu başarıyla eklendi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Data.ToString());
            }

            con.Close();
        }
        public void read(string item)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dataTable = new DataTable();
                // Satır eklenmişse aynı işlev tekrar kullanmasını önler.
                if (dataTable.Rows.Count.Equals(0))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(item, con);
                    sqlDataAdapter.Fill(dataTable);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void read(string item1, string item2)
        {

        }
        public void update(string conString)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = new SqlCommand(conString, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void delete(string conString)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd = new SqlCommand(conString, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool kullaniciSorgusu(string kullaniciadi, string sifre)
        {
             sorgu = "SELECT * FROM Personel where kullaniciadi=@user AND şifre=@pass";
            // con = new SqlConnection("Data Source=DESKTOP-670IFMK\\SQLEXPRESS;Initial Catalog=StokTakip;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", kullaniciadi);
            cmd.Parameters.AddWithValue("@pass", sifre);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                con.Close();
                return false;
            }
        }
    }
}