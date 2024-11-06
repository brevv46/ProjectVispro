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

namespace ProjectVispro
{
    public partial class FormHistoryTransaksi : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        private object dataGridViewHistory;

        public FormHistoryTransaksi()
        {
            alamat = "server=localhost; database=db_carrent; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormHistoryTransaksi_Load(object sender, EventArgs e)
        {
            try
            {
                // Open connection to database
                koneksi.Open();

                // Query to get all transaction history
                query = "SELECT Penyewa AS 'Nama Penyewa', No_Ktp AS 'Nomor KTP', No_Hp AS 'Nomor HP', Tanggal_ambil AS 'Tanggal Diambil', Tanggal_akhir AS 'Tanggal Dikembalikan', Pembayaran AS 'Pembayaran' FROM tb_transaksi";

                // Execute command
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);

                // Fill DataSet and bind to DataGridView
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];

                // Customize column widths
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[5].Width = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
