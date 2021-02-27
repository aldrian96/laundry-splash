using Luthor.lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Splash.FormCRUD
{
    public partial class FormAddPelanggan : Form
    {
        Guna.UI.WinForms.GunaButton btrf;
        public FormAddPelanggan(Guna.UI.WinForms.GunaButton btrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            btrf = btrefresh;
        }

        private void FormAddPelanggan_Load(object sender, EventArgs e)
        {

        }

        private void gunaButtonTambah_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var nama = txtNama.Text;
                var alamat = txtAlamat.Text;
                var jk = txtJenisKelamin.Text;
                var noTlp = txtTelepon.Text;
                if (Db.Insert("tb_member", $"null, '{nama}','{alamat}', '{jk}','{noTlp}'"))
                {
                    MessageBox.Show("Data Telah Ditambahkan!");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal Menambah Pelanggan. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool isFilled()
        {
            if (txtNama.Text.Length > 0 && txtAlamat.Text.Length > 0 && txtTelepon.Text.Length > 0 && txtJenisKelamin.Text.Length > 0) return true;
            return false;
        }
        private void rbLakilaki_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLakilaki.Checked)
            {
                txtJenisKelamin.Text = "L";
            }
        }

        private void rbPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPerempuan.Checked) txtJenisKelamin.Text = "P";
        }

        private void gunaButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
