using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProjectVispro
{
    public partial class FormTransaksi : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public FormTransaksi()
        {
            alamat = "server=localhost; database=db_carrent; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FormHistoryTransaksi formHistoryTransaksi = new FormHistoryTransaksi();
            formHistoryTransaksi.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = "SELECT Penyewa, No_Ktp, No_hp, Tanggal_ambil, Tanggal_akhir, Pembayaran FROM tb_transaksi";
                MySqlCommand perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                // Menampilkan data pada DataGridView
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "Nama Penyewa";
                dataGridView1.Columns[1].HeaderText = "Nomor KTP";
                dataGridView1.Columns[2].HeaderText = "Nomor HP";
                dataGridView1.Columns[3].HeaderText = "Tanggal Diambil";
                dataGridView1.Columns[4].HeaderText = "Tanggal Dikembalikan";
                dataGridView1.Columns[5].HeaderText = "Pembayaran";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengambil data: " + ex.Message);
            }
        }
    }
}
