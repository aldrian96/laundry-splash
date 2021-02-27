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
    public partial class FormRegistrasi : Form
    {
        public FormRegistrasi()
        {
            InitializeComponent();
        }

        public string getIdPelanggan;

        private void FormRegistrasi_Load(object sender, EventArgs e)
        {
            LoadTheme();
            readDataPelanggan();
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
            /*label7.ForeColor = ThemeColor.SecondaryColor;
            label6.ForeColor = ThemeColor.PrimaryColor;*/
        }

        // READ
        private void readDataPelanggan()
        {
            string query = "SELECT * FROM tb_member";

            DataTable data = Db.Read(query);
            dataTbPelanggan.AutoGenerateColumns = false;
            dataTbPelanggan.DataSource = data;
        }

        private void gunaButtonAdd_Click(object sender, EventArgs e)
        {
            Form addPelanggan = new FormAddPelanggan(btnRefresh);
            addPelanggan.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            readDataPelanggan();
        }

        //DELETE
        private void gunaButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getIdPelanggan))
            {
                deleteDataPelanggan();
            }
            else MessageBox.Show("Tolong pilih data yang Ingin Di Hapus!", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void deleteDataPelanggan()
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin Menghapus Data Ini?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_member", $"id = {getIdPelanggan}");
                readDataPelanggan();
                MessageBox.Show("Data Telah Dihapus!");
            }
        }

        private void dataTbPelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataTbPelanggan.CurrentCell.RowIndex;
            getIdPelanggan = dataTbPelanggan.Rows[row].Cells["ColumnId"].Value.ToString();
        }

        //Edit
        private void gunaButtonEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getIdPelanggan))
            {
                Form editPelanggan = new FormEditPelanggan(getIdPelanggan, btnRefresh);
                editPelanggan.ShowDialog();
            }
            else MessageBox.Show("Tolong pilih data yang Ingin diubah", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        // Search
        private void searchDataPelanggan()
        {
            string query = "SELECT * FROM tb_member WHERE tb_member.nama LIKE '%" + txtSearch.Text + "%' " +
                           "OR tb_member.alamat LIKE '%" + txtSearch.Text + "%' OR tb_member.jenis_kelamin LIKE '%" + txtSearch.Text + "%' OR tb_member.tlp LIKE '%" + txtSearch.Text + "%'";

            DataTable data = Db.Read(query);
            dataTbPelanggan.AutoGenerateColumns = false;
            dataTbPelanggan.DataSource = data;
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
                searchDataPelanggan();
            }
        }
    }

}
