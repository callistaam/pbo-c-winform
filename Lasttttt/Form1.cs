using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

// NAMA     : CALLISTA ALODIA MARELLA
// NIM      : 222410103092
// KELAS    : Pemrograman Berbasis Obyek C
namespace Lasttttt
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection vConn; // Deklarasi variabel vConn

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inisialisasi dan buka koneksi saat form dimuat
            vConn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=Ichacantik10; Database=Tugas;");
            vConn.Open();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=Ichacantik10; Database=Tugas;"))
                {
                    connection.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO TRANSAKSI (nama, alamat, No_Telepon, Tanggal_Transaksi, Laptop_Yang_Dibeli, Jumlah_Laptop_Yang_Dibeli) " +
                                          "VALUES (@Nama, @Alamat, @NoTelepon, @TanggalTransaksi, @LaptopYangDibeli, @JumlahLaptopYangDibeli)";
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Nama", tbNama.Text);
                        cmd.Parameters.AddWithValue("@Alamat", tbAlamat.Text);
                        cmd.Parameters.AddWithValue("@NoTelepon", tbTelepon.Text);
                        cmd.Parameters.AddWithValue("@TanggalTransaksi", DateTime.Now);
                        cmd.Parameters.AddWithValue("@LaptopYangDibeli", tbLaptop.Text);
                        cmd.Parameters.AddWithValue("@JumlahLaptopYangDibeli", tbJumlah.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data inserted successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert data into the database.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}