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
    public partial class FormEditJenis : Form
    {
        string getIdJenis;
        Guna.UI.WinForms.GunaButton btrf;
        public FormEditJenis(string id, Guna.UI.WinForms.GunaButton btrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            getIdJenis = id;
            btrf = btrefresh;
        }
        private void FormEditJenis_Load(object sender, EventArgs e)
        {
            DataTable dataEdit = Db.Read("tb_jenis", "*", $"id = {getIdJenis}");
            txtJenisPaket.Text = dataEdit.Rows[0].Field<string>("jenis");
        }

        private void gunaButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var jenisPaket = txtJenisPaket.Text;
                if (Db.Update("tb_jenis", $"jenis = '{jenisPaket}'", $"id = {getIdJenis}"))
                {
                    MessageBox.Show("Data Telah Diubah!");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal Menambah Jenis Paket. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool isFilled()
        {
            if (txtJenisPaket.Text.Length > 0) return true;
            return false;
        }

    }
}
