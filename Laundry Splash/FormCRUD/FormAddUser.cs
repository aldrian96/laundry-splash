using Luthor.lib;
using Luthor.lib.Encryption;
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
    
    public partial class FormAddUser : Form
    {
        Guna.UI.WinForms.GunaButton btrf;

        public FormAddUser(Guna.UI.WinForms.GunaButton btrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            btrf = btrefresh;
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            DataTable outlet = Db.Read("tb_outlet", "id, nama");
            cbOutlet.DisplayMember = "nama";
            cbOutlet.ValueMember = "id";
            cbOutlet.DataSource = outlet;
            cbOutlet.StartIndex = -1;

        }

        private void gunaButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // CREATE
        private void gunaButtonTambah_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var nama = txtNama.Text;
                var username = txtUsername.Text;
                var password = Sha256.Encrypt(txtPassword.Text);
                var outlet = "null";
                if (cbRole.SelectedIndex == 1) outlet = cbOutlet.SelectedValue.ToString();
                var role = cbRole.Text;
                if (Db.Insert("tb_user", $"null, '{nama}','{username}','{password}', {outlet},'{role}'"))
                {
                    MessageBox.Show("Data Telah Ditambahkan!");
                    btrf.PerformClick();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show($"Gagal Menambah User. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        private bool isFilled()
        {
            if(txtNama.Text.Length > 0 && txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0 && cbRole.SelectedIndex >= 0 && cbOutlet.SelectedIndex!=2)return true;
            return false;
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRole.SelectedIndex == 1)
            {
                cbOutlet.Enabled = true;
            }
            else
            {
                cbOutlet.Enabled = false;
            }
        }
    }
}
