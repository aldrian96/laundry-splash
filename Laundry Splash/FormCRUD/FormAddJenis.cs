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
    public partial class FormAddJenis : Form
    {
        Guna.UI.WinForms.GunaButton btrf;

        public FormAddJenis(Guna.UI.WinForms.GunaButton btrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            btrf = btrefresh;
        }

        private void FormAddJenis_Load(object sender, EventArgs e)
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
                var jeniPaket = txtJenisPaket.Text;
                if (Db.Insert("tb_jenis", $"null, '{jeniPaket}'"))
                {
                    MessageBox.Show("Data Telah Ditambahkan!");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal Menambah Jenis Paket. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Tolong isi Field yang kosong");
        }
        private bool isFilled()
        {
            if (txtJenisPaket.Text.Length > 0) return true;
            return false;
        }
    }
}
