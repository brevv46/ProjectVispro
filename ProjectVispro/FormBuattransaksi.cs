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

namespace ProjectVispro
{
    public partial class FormBuattransaksi : Form
    {
        private MySqlConnection koneksi;
        private MySqlCommand perintah;
        private string alamat, query;
        public FormBuattransaksi()
        {
            alamat = "server=localhost; database=db_carrent; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void FormBuattransaksi_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (!string.IsNullOrEmpty(txtPenyewa.Text) &&
                    !string.IsNullOrEmpty(txtKtp.Text) &&
                    !string.IsNullOrEmpty(txtHp.Text) &&
                    !string.IsNullOrEmpty(txtTanggalDiambil.Text) &&
                    !string.IsNullOrEmpty(txtDikembalikan.Text) &&
                    !string.IsNullOrEmpty(txtPembayaran.Text))
                {
                    
                    query = "INSERT INTO tb_transaksi (Penyewa, No_Ktp, No_hp, Tanggal_ambil, Tanggal_akhir, Pembayaran) " +
                            "VALUES (@NamaPenyewa, @NomorKtp, @NomorHp, @TanggalDiambil, @TanggalDikembalikan, @Pembayaran)";

                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);

                    
                    perintah.Parameters.AddWithValue("@NamaPenyewa", txtPenyewa.Text);
                    perintah.Parameters.AddWithValue("@NomorKtp", txtKtp.Text);
                    perintah.Parameters.AddWithValue("@NomorHp", txtHp.Text);
                    perintah.Parameters.AddWithValue("@TanggalDiambil", txtTanggalDiambil.Text);
                    perintah.Parameters.AddWithValue("@TanggalDikembalikan", txtDikembalikan.Text);
                    perintah.Parameters.AddWithValue("@Pembayaran", txtPembayaran.Text);

                    perintah.ExecuteNonQuery();
                    koneksi.Close();

                    MessageBox.Show("Data berhasil disimpan.");

                    
                    FormTransaksi formTransaksi = new FormTransaksi();
                    formTransaksi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Silakan isi semua field.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
    }
}
