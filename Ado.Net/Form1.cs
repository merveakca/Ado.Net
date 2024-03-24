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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            // Sql Server a bağlanmak için bir bağlantı cümlesi (ConnectionString) oluşturalım.
            // Data Source= server adı
            // Initial Catalog= veritabanı adı
            // Integrated Security=True  >> windows authentication ile bağlan

            string ConnStr = "Data Source=DESKTOP-D84DF12\\SQLEXPRESS01; Initial Catalog=NORTHWND; Integrated Security=True";

            SqlConnection cn = new SqlConnection(ConnStr);

            try
            {
                cn.Open();
                // SqlCommand cmd = new SqlCommand("Select * from Products", cn);
                SqlCommand cmd = new SqlCommand("Select ProductName from Products");
                cmd.Connection = cn;
                // ExecuteReader() metodu select sorgusunu çalıştırarak sonucunu dr nesnesine yükler.
                SqlDataReader dr = cmd.ExecuteReader();
                // dr.Read() metodu eğer dr üzerinde sıradaki satırda herhangi bir data varsa geriye true yoksa false döner.
                while (dr.Read())
                {
                    lstListe.Items.Add(dr["ProductName"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        List<Product> UrunListesi = new List<Product>();
        private void btnNesne_Click(object sender, EventArgs e)
        {
            UrunleriGetir();
        }

        private void UrunleriGetir()
        {

            SqlConnection cn = new SqlConnection(Db.ConnectionString);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Products", cn);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // Value type / references type

                    // Gelen datayı kullanarak ürün nesneleri yapmak istiyoruz.
                    Product p = new Product()
                    {
                        ProductID = Convert.ToInt32(dr["ProductID"]),
                        ProductName = dr["ProductName"].ToString(),
                        CategoryID = Convert.ToInt32(dr["CategoryID"]),
                        Stock = Convert.ToInt32(dr["UnitsInStock"]),
                        UnitPrice = Convert.ToDouble(dr["UnitPrice"])
                    };

                    UrunListesi.Add(p);
                }

                // Listeye doldurulan ürün bilgilerini getirelim.

                foreach (var item in UrunListesi)
                {
                    lstListe.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                cn.Close();
                MessageBox.Show(UrunListesi.Count.ToString());
            }
        }

        private void btnYakala_Click(object sender, EventArgs e)
        {
            var item = (Product)lstListe.SelectedItem;
            if (item != null)
            {
                MessageBox.Show(item.ProductName);
            }
        }

        private void btnUrunleriGetir_Click(object sender, EventArgs e)
        {
            UrunleriGetirDTSource();
        }

        private void UrunleriGetirDTSource()
        {
            SqlConnection cn = new SqlConnection(Db.ConnectionString);
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Products", cn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lstListe.DataBindings.Clear();

                lstListe.DataSource = dt;
                lstListe.DisplayMember = "ProductName";
                lstListe.ValueMember = "ProductID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        SqlConnection cn;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            // ürün ekliyoruz.
            cn = new SqlConnection(Db.ConnectionString);

            try
            {
                cn.Open();
                SqlCommand cmdEkle = new SqlCommand("Insert into Products (ProductName,CategoryID,UnitsInStock,UnitPrice) values(@pName,@CtID,@Stk,@uPrice)", cn);
                cmdEkle.Parameters.AddWithValue("@pName", "IPhone 15 Pro Max");
                cmdEkle.Parameters.AddWithValue("@CtID", 2);
                cmdEkle.Parameters.AddWithValue("@Stk", 1300);
                cmdEkle.Parameters.AddWithValue("@uPrice", 156000);

                // ExecuteNonQuery etkilenensatir sayisini geriye döner.
                int etkilenenSatir = cmdEkle.ExecuteNonQuery();

                if (etkilenenSatir > 0)
                {
                    UrunleriGetir();
                    MessageBox.Show("Ekleme işlemi başarılı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                // silmek istediğimiz ürüne ulaşmamız gerekiyor.
                // 2. butona basarak verileri listeye yükleseydik, yani her bir elemanı bir nesne olarak ekleseydik;

                //var secilenUrun = (Product)lstListe.SelectedItem;
                //MessageBox.Show(secilenUrun.ProductID.ToString());

                //listeyi 4. butona (datatable) basarak

                int secilenID = (int)lstListe.SelectedValue;
                //MessageBox.Show(secilenID.ToString());

                cn = new SqlConnection(Db.ConnectionString);
                cn.Open();
                SqlCommand cmdSil = new SqlCommand("Delete from Products where ProductID=@ID", cn);
                cmdSil.Parameters.AddWithValue("@ID", secilenID);

                int etkilenenSatir = cmdSil.ExecuteNonQuery();
                if (etkilenenSatir > 0)
                {
                    MessageBox.Show("Silme işlemi başarılı.");
                    UrunleriGetirDTSource();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
