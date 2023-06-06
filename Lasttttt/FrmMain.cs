using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

// NAMA     : CALLISTA ALODIA MARELLA
// NIM      : 222410103092
// KELAS    : Pemrograman Berbasis Obyek C
namespace Lasttttt
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        string vStrConnection = "Server=localhost; Port=5432; User Id=postgres; Password=Ichacantik10; Database=Tugas;";
        NpgsqlConnection vCon;
        NpgsqlCommand vCmd;

        private void connection()
        {
            vCon = new NpgsqlConnection();
            vCon.ConnectionString = vStrConnection;
            if (vCon.State == ConnectionState.Closed)
            {
                vCon.Open();
            }
        }

        public DataTable getdata(string sql)
        {
            DataTable dt = new DataTable();
            connection();
            vCmd = new NpgsqlCommand();
            vCmd.Connection = vCon;
            vCmd.CommandText = sql;

            NpgsqlDataReader dr = vCmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            connection();
            LoadData();
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM LAPTOP";
            DataTable dt = getdata(sql);
            dgData.DataSource = dt;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(vStrConnection))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO LAPTOP (nama, harga, stok) VALUES (@Nama, @Harga, @Stok)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new NpgsqlParameter("@Nama", tbNama.Text));
                    cmd.Parameters.Add(new NpgsqlParameter("@Harga", Convert.ToInt32(tbHarga.Text)));
                    cmd.Parameters.Add(new NpgsqlParameter("@Stok", Convert.ToInt32(tbStok.Text)));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    tbNama.Text = "";
                    tbHarga.Text = "";
                    tbStok.Text = "";
                    LoadData(); // Perbarui tampilan DataGridView setelah input data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan data ke database.");
            }
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}