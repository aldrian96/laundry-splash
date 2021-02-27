using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luthor.lib;

namespace Laundry_Splash.FormCRUD
{
    public partial class FormEditOutlet : Form
    {
        string getIdOutlet;
        Guna.UI.WinForms.GunaButton btrf;
        public FormEditOutlet(string id, Guna.UI.WinForms.GunaButton btrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            getIdOutlet = id;
            btrf = btrefresh;
        }

        private void FormEditOutlet_Load(object sender, EventArgs e)
        {
            DataTable dataEdit = Db.Read("tb_outlet", "*", $"id = {getIdOutlet}");
            txtNamaOutlet.Text = dataEdit.Rows[0].Field<string>("nama");
            txtAlamat.Text = dataEdit.Rows[0].Field<string>("alamat");
            txtTelepon.Text = dataEdit.Rows[0].Field<string>("tlp");
        }

        private void gunaButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool isFilled()
        {
            if (txtNamaOutlet.Text.Length > 0 && txtAlamat.Text.Length > 0 && txtTelepon.Text.Length != 2) return true;
            return false;
        }

        private void btnEditOutlet_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var nama = txtNamaOutlet.Text;
                var alamat = txtAlamat.Text;
                var telepon = txtTelepon.Text;

                if (Db.Update("tb_outlet", $"nama = '{nama}', alamat = '{alamat}', tlp = '{telepon}'", $"id = {getIdOutlet}"))
                {
                    MessageBox.Show("Data Berhasi Diubah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else MessageBox.Show($"Gagal Mengubah Outlet. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
