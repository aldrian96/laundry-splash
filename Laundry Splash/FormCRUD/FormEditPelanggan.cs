using Guna.UI.WinForms;
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
    public partial class FormEditPelanggan : Form
    {
        string getIdPelanggan;
        Guna.UI.WinForms.GunaButton btrf;

        public FormEditPelanggan(string id, Guna.UI.WinForms.GunaButton btrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            getIdPelanggan = id;
            btrf = btrefresh;
        }

        private void FormEditPelanggan_Load(object sender, EventArgs e)
        {
            DataTable dataEdit = Db.Read("tb_member", "*", $"id = {getIdPelanggan}");
            
            txtNama.Text = dataEdit.Rows[0].Field<string>("nama");
            txtAlamat.Text = dataEdit.Rows[0].Field<string>("alamat");
            txtTelepon.Text = dataEdit.Rows[0].Field<string>("tlp");
            txtJenisKelamin.Text = dataEdit.Rows[0].Field<string>("jenis_kelamin");
            var jk = dataEdit.Rows[0].Field<string>("jenis_kelamin");
            if (jk == "L")
            {
                rbLakilaki.Checked = true;
            }
            else
            {
                rbPerempuan.Checked = true;
            }

        }

        private void gunaButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEditOutlet_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var nama = txtNama.Text;
                var alamat = txtAlamat.Text;
                var jk = txtJenisKelamin.Text;
                var noTlp = txtTelepon.Text;
                if (Db.Update("tb_member", $"nama = '{nama}', alamat = '{alamat}', tlp = {noTlp}, jenis_kelamin = '{jk}'", $"id = {getIdPelanggan}"))
                {
                    MessageBox.Show("Data Telah Diubah!");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal Mengubah Pelanggan. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (rbPerempuan.Checked)
            {
                txtJenisKelamin.Text = "P";
            }
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
