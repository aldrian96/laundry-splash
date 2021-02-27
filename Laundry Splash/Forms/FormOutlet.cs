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
    public partial class FormOutlet : Form
    {
        public FormOutlet()
        {
            InitializeComponent();
        }

        public string getIdOutlet;


        private void FormOutlet_Load(object sender, EventArgs e)
        {
            LoadTheme();
            readDataOutlet();
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

        private void gunaButtonSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Visible == true)
            {
                txtSearch.Visible = false;

            }
            else
            {
                txtSearch.Visible = true;
            }
        }

        private void btnAddOutlet_Click(object sender, EventArgs e)
        {
            Form AddOutlet = new FormAddOutlet(btnRefresh);
            AddOutlet.ShowDialog();
        }

        private void btnDeleteOutlet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getIdOutlet))
            {
                deleteDataOutlet();
            }
            else MessageBox.Show("Tolong pilih data yang Ingin Di Hapus!", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnEditOutlet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getIdOutlet))
            {
                Form EditUser = new FormEditOutlet(getIdOutlet, btnRefresh);
                EditUser.ShowDialog();
            }
            else MessageBox.Show("Tolong pilih data yang Ingin diubah", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // read
        public void readDataOutlet()
        {
            dataTbOutlet.AutoGenerateColumns = false;
            dataTbOutlet.DataSource = Db.Read("tb_outlet", "*");

            /*string query = "SELECT * tb_outlet";
            DataTable data = Db.Read(query);
            dataTbOutlet.AutoGenerateColumns = false;
            dataTbOutlet.DataSource = data;*/
        }

        // DELETE
        private void deleteDataOutlet()
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin Menghapus Data Ini?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_outlet", $"id = {getIdOutlet}");
                readDataOutlet();
                MessageBox.Show("Data Telah Dihapus!");
            }
        }

        //Search
        public void searchDataOutlet()
        {
            string query = "SELECT * FROM tb_outlet WHERE tb_outlet.nama LIKE '%" + txtSearch.Text + "%' " +
                           "OR tb_outlet.alamat LIKE '%" + txtSearch.Text + "%' OR tb_outlet.tlp LIKE '%" + txtSearch.Text + "%'";

            DataTable data = Db.Read(query);
            dataTbOutlet.AutoGenerateColumns = false;
            dataTbOutlet.DataSource = data;
        }

        // Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            readDataOutlet();
        }

        private void dataTbOutlet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataTbOutlet.CurrentCell.RowIndex;
            getIdOutlet = dataTbOutlet.Rows[row].Cells["ColumnId"].Value.ToString();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Cari") txtSearch.ResetText();
            txtSearch.ForeColor = Color.DarkGray;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length <= 0)
            {
                txtSearch.Text = "Cari";
                txtSearch.ForeColor = Color.DarkGray;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "Cari")
            {
                searchDataOutlet();
            }
        }
    }
}
