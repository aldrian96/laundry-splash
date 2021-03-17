using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laundry_Splash.FormCRUD;
using Luthor.lib;

namespace Laundry_Splash.Forms
{
    public partial class FormJenis : Form
    {
        public string getIdJenis;
        public FormJenis()
        {
            InitializeComponent();
        }

        private void FormJenis_Load(object sender, EventArgs e)
        {
            LoadTheme();
            readDataPaket();
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
        private void readDataPaket()
        {
            string query = "SELECT * FROM tb_jenis";

            DataTable data = Db.Read(query);
            dataTbJenis.AutoGenerateColumns = false;
            dataTbJenis.DataSource = data;
        }

        private void gunaButtonAdd_Click(object sender, EventArgs e)
        {
            Form AddJenisPaket = new FormAddJenis(btnRefresh);
            AddJenisPaket.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            readDataPaket();
        }

        public void deleteDataJenis()
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin Menghapus Data Ini?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_jenis", $"id = {getIdJenis}");
                readDataPaket();
                MessageBox.Show("Data Telah Dihapus!");

            }
        }
        private void gunaButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getIdJenis))
            {
                deleteDataJenis();
            }
            else MessageBox.Show("Tolong pilih data yang Ingin Di Hapus!", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataTbJenis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataTbJenis.CurrentCell.RowIndex;
            getIdJenis = dataTbJenis.Rows[row].Cells["ColumnId"].Value.ToString();
        }

        private void gunaButtonEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getIdJenis))
            {
                Form editDataJenis = new FormEditJenis(getIdJenis, btnRefresh);
                editDataJenis.ShowDialog();
            }
            else MessageBox.Show("Tolong pilih data yang Ingin diubah", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        // SEARCH
        private void searchDataUser()
        {
            string query = "SELECT * FROM tb_jenis WHERE tb_jenis.jenis LIKE '%" + txtSearch.Text + "%'";
                           

            DataTable data = Db.Read(query);
            dataTbJenis.AutoGenerateColumns = false;
            dataTbJenis.DataSource = data;
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "Cari")
            {
                searchDataUser();
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
    }
}
