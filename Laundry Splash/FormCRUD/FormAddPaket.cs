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
    public partial class FormAddPaket : Form
    {
        Guna.UI.WinForms.GunaButton btrf;
        public FormAddPaket(Guna.UI.WinForms.GunaButton btrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            btrf = btrefresh;
        }

        private void FormAddPaket_Load(object sender, EventArgs e)
        {
            cbOutlet.DisplayMember = "nama";
            cbOutlet.ValueMember = "id";
            cbOutlet.DataSource = Db.Read("tb_outlet", "id, nama");
            cbOutlet.StartIndex = -1;

            cbJenis.DisplayMember = "jenis";
            cbJenis.ValueMember = "id";
            cbJenis.DataSource = Db.Read("tb_jenis", "id, jenis");
            cbJenis.StartIndex = -1;
        }

        private void gunaButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunaButtonTambah_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var namaPaket = txtNamaPaket.Text;
                var harga = txtHarga.Text;
                var outlet = cbOutlet.SelectedValue.ToString();
                var jenis = cbJenis.SelectedValue;
                if (Db.Insert("tb_paket", $"null, '{outlet}', '{jenis}', '{namaPaket}', '{harga}'"))
                {
                    MessageBox.Show("Data Telah Ditambahkan!");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal Menambah Paket. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool isFilled()
        {
            if (txtNamaPaket.Text.Length > 0 && txtHarga.Text.Length > 0 && cbJenis.SelectedIndex >= 0 && cbOutlet.SelectedIndex != 2) return true;
            return false;
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
