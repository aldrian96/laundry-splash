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
    public partial class FormEditPaket : Form
    {
        string getIdPaket;
        Guna.UI.WinForms.GunaButton btrf;

        public FormEditPaket(string id, Guna.UI.WinForms.GunaButton btrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            getIdPaket = id;
            btrf = btrefresh;
        }

        private void FormEditPaket_Load(object sender, EventArgs e)
        {
            DataTable dataEdit = Db.Read("tb_paket", "*", $"id = {getIdPaket}");
            txtNamaPaket.Text = dataEdit.Rows[0].Field<string>("nama_paket");
            txtHarga.Text = dataEdit.Rows[0].Field<int>("harga").ToString();
            cbOutlet.DataSource = Db.Read("tb_outlet", "*");
            cbOutlet.DisplayMember = "nama";
            cbOutlet.ValueMember = "id";
            cbJenis.DataSource = Db.Read("tb_jenis", "*");
            cbJenis.DisplayMember = "jenis";
            cbJenis.ValueMember = "id";
        }

        private void gunaButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private bool isFilled()
        {
            if (txtNamaPaket.Text.Length > 0 && txtHarga.Text.Length > 0 && cbJenis.SelectedIndex >= 0 && cbOutlet.SelectedIndex != 2) return true;
            return false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var namaPaket = txtNamaPaket.Text;
                var harga = txtHarga.Text;
                var outlet = cbOutlet.SelectedValue.ToString();
                var jenis = cbJenis.SelectedValue;
                if (Db.Update("tb_paket", $"id_outlet = {outlet}, id_jenis = '{jenis}', nama_paket = '{namaPaket}', harga = '{harga}'", $"id = {getIdPaket}"))
                {
                    MessageBox.Show("Data Telah Diubah!");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal Menambah Paket. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
