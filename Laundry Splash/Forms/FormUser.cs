using Laundry_Splash.FormCRUD;
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

namespace Laundry_Splash.Forms
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            LoadTheme();
        }

        public string getId;

        private void FormUser_Load(object sender, EventArgs e)
        {
            readDataUser();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        // READ
        private void readDataUser()
        {
            string query = "SELECT tb_user.*, tb_outlet.nama as namaOutlet FROM tb_user LEFT JOIN tb_outlet ON tb_user.id_outlet = tb_outlet.id";
           
                DataTable data = Db.Read(query);
                dataTbUser.AutoGenerateColumns = false;
                dataTbUser.DataSource = data;
        }

        // SEARCH
        private void searchDataUser()
        {
            string query = "SELECT tb_user.*, tb_outlet.nama as namaOutlet FROM tb_user LEFT JOIN tb_outlet ON tb_user.id_outlet = tb_outlet.id WHERE tb_user.nama LIKE '%"+txtSearch.Text+"%' " +
                           "OR tb_user.username LIKE '%"+txtSearch.Text+"%' OR tb_user.role LIKE '%"+txtSearch.Text+"%' OR tb_outlet.nama LIKE '%"+txtSearch.Text+"%'";

            DataTable data = Db.Read(query);
            dataTbUser.AutoGenerateColumns = false;
            dataTbUser.DataSource = data;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Cari") txtSearch.ResetText();
            txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length <= 0)
            {
                txtSearch.Text = "Cari";
                txtSearch.ForeColor = Color.DarkGray;
            }
        }

        // DELETE
        private void deleteDataUser()
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin Menghapus Data Ini?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_user", $"id = {getId}");
                readDataUser();
                MessageBox.Show("Data Telah Dihapus!");

            }
        }

        private void gunaButtonAdd_Click(object sender, EventArgs e)
        {
            Form AddUser = new FormAddUser(btnRefresh);
            AddUser.ShowDialog();
        }

        private void gunaButtonSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Visible == true)
            {
                txtSearch.Visible = false;

            }
            else
            {
                txtSearch.Visible = true;
            }
        }

        private void gunaButtonDelete_Click(object sender, EventArgs e)
        {
            deleteDataUser();
        }
        private void gunaButtonEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getId))
            {
                Form EditUser = new FormEditUser(getId, btnRefresh);
                EditUser.ShowDialog();
            }
            else MessageBox.Show("Tolong pilih data yang Ingin diubah", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "Cari")
            {
                searchDataUser();
            }
            
        }

        private void dataTbUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataTbUser.CurrentCell.RowIndex;
            getId = dataTbUser.Rows[row].Cells["ColumnId"].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            readDataUser();
        }

        
    }
}
