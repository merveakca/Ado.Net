using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.Net
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection cn = null;
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                //using ifadesi SqlConnection nesnesinin işi bittiğinde otomatik olarak Dispose() edilmesini sağlar. Bu bağlantının doğru bir şekilde kapatılmasını ve kaynakların serbest bırakılmasını sağlar.

                using (cn = new SqlConnection(Db.ConnectionString))
                {
                    cn.Open();

                    SqlCommand cmdKategoriGetir = new SqlCommand("Select CategoryID,CategoryName,Description from Categories", cn);

                    SqlDataAdapter da = new SqlDataAdapter(cmdKategoriGetir);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    cmbKategoriler.DisplayMember = "CategoryName";
                    cmbKategoriler.ValueMember = "CategoryID";
                    cmbKategoriler.DataSource = dt;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu" + ex.Message);
            }
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (cn = new SqlConnection(Db.ConnectionString))
                {
                    int catID = Convert.ToInt32(cmbKategoriler.SelectedValue);

                    cn.Open();

                    SqlCommand cmdUrunleriGetir = new SqlCommand("Select ProductID,ProductName from Products where CategoryID=@id", cn);
                    cmdUrunleriGetir.Parameters.AddWithValue("@id", catID);

                    SqlDataAdapter da = new SqlDataAdapter(cmdUrunleriGetir);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    lstUrunListesi.DisplayMember = "ProductName";
                    lstUrunListesi.ValueMember = "ProductID";
                    lstUrunListesi.DataSource = dt;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu + {ex.Message}");
            }
        }

        private void lstUrunListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (cn=new SqlConnection(Db.ConnectionString))
                {
                    int secilenUrunID = (int)lstUrunListesi.SelectedValue;
                    lblBaslik.Text = $"{lstUrunListesi.Text} AdlıÜrünün Sipariş Detay Listesi";

                    SqlCommand cmdUrunDetaylari = new SqlCommand("Select * from [Order Details] where ProductID=@id", cn);
                    cmdUrunDetaylari.Parameters.AddWithValue("@id", secilenUrunID);

                    SqlDataAdapter da = new SqlDataAdapter(cmdUrunDetaylari);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvSiparisler.DataSource = dt;
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"Bir hata oluştu + {ex.Message}");
            }
        }
    }
}
