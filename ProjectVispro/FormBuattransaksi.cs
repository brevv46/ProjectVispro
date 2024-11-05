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
        public FormBuattransaksi()
        {
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
            FormTransaksi formTransaksi = new FormTransaksi();
            formTransaksi.Show();
        }
    }
}
