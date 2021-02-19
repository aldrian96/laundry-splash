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
using Luthor.lib.Encryption;

namespace Laundry_Splash.FormCRUD
{
    
    public partial class FormEditUser : Form
    {
        string getId;
        Guna.UI.WinForms.GunaButton btrf;
        
        public FormEditUser(string id, Guna.UI.WinForms.GunaButton btrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            getId = id;
            btrf = btrefresh;
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            DataTable dataEdit = Db.Read("tb_user", "*", $"id = {getId}");
            txtNama.Text = dataEdit.Rows[0].Field<string>("nama");
            txtUsername.Text = dataEdit.Rows[0].Field<string>("username");
            txtPassword.Text = dataEdit.Rows[0].Field<string>("password");
            cbOutlet.DataSource = Db.Read("tb_outlet", "*");
            cbOutlet.DisplayMember = "nama";
            cbOutlet.ValueMember = "id";
            cbRole.SelectedIndex = cbRole.FindStringExact(dataEdit.Rows[0].Field<string>("role"));
        }

        private void gunaButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private bool isFilled()
        {
            if (txtNama.Text.Length > 0 && txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0 && cbRole.SelectedIndex >= 0 && cbOutlet.SelectedIndex != 2) return true;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var nama = txtNama.Text;
                var username = txtUsername.Text;
                var password = Sha256.Encrypt(txtPassword.Text);
                var outlet = "null";
                if (cbRole.SelectedIndex == 1) outlet = cbOutlet.SelectedValue.ToString();
                var role = cbRole.Text;
                if (Db.Update("tb_user", $"nama = '{nama}', username = '{username}', password = '{password}', id_outlet = {outlet}, role = '{role}'", $"id = {getId}"))
                {
                    MessageBox.Show("Data Berhasi Diubah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else MessageBox.Show($"Gagal Mengubah User. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
