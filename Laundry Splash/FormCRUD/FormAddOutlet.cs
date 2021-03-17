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
    public partial class FormAddOutlet : Form
    {
        Guna.UI.WinForms.GunaButton btrf;
        public FormAddOutlet(Guna.UI.WinForms.GunaButton btrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            btrf = btrefresh;
        }

        private void FormAddOutlet_Load(object sender, EventArgs e)
        {
            
        }

        private void gunaButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunaButtonTambah_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var nama = txtNamaOutlet.Text;
                var alamat = txtAlamat.Text;
                var telepon = txtTelepon.Text;
                if (Db.Insert("tb_outlet", $"null, '{nama}','{alamat}','{telepon}'"))
                {
                    MessageBox.Show("Data Telah Ditambahkan!");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal Menambah Outlet. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Tolong isi Field yang kosong!");
        }
        private bool isFilled()
        {
            if (txtNamaOutlet.Text.Length > 0 && txtAlamat.Text.Length > 0 && txtTelepon.Text.Length != 2) return true;
            return false;
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
