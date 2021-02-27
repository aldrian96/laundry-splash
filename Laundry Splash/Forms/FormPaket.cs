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
    public partial class FormPaket : Form
    {
        public string getIdPaket;
        public FormPaket()
        {
            InitializeComponent();
        }

        private void FormProduk_Load(object sender, EventArgs e)
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
        // READ
        private void readDataPaket()
        {
            string query = "SELECT * FROM tb_paket LEFT JOIN tb_jenis ON tb_paket.id_jenis = tb_jenis.id LEFT JOIN tb_outlet ON tb_paket.id_outlet = tb_outlet.id ORDER BY tb_paket.id DESC";

            DataTable data = Db.Read(query);
            dataTbPaket.AutoGenerateColumns = false;
            dataTbPaket.DataSource = data;
        }

        private void gunaButtonAdd_Click(object sender, EventArgs e)
        {
            /*Form AddPaket = new FormAddPaket();
            AddPaket.ShowDialog();*/

            new FormAddPaket(btnRefresh).ShowDialog();
        }

        // DELETE
        private void deleteDataPaket()
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin Menghapus Data Ini?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_paket", $"id = {getIdPaket}");
                readDataPaket();
                MessageBox.Show("Data Telah Dihapus!");

            }
        }

        private void gunaButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getIdPaket))
            {
                deleteDataPaket();
            }
            else MessageBox.Show("Tolong pilih data yang Ingin Di Hapus!", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            readDataPaket();
        }

        private void dataTbPaket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataTbPaket.CurrentCell.RowIndex;
            getIdPaket = dataTbPaket.Rows[row].Cells["ColumnId"].Value.ToString();
        }

        private void gunaButtonEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getIdPaket))
            {
                Form editPaket = new FormEditPaket(getIdPaket, btnRefresh);
                editPaket.ShowDialog();
            }
            else MessageBox.Show("Tolong pilih data yang Ingin diubah", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // SEARCH
        private void searchDataUser()
        {
            string query = "SELECT * FROM tb_paket LEFT JOIN tb_jenis ON tb_paket.id_jenis = tb_jenis.id LEFT JOIN tb_outlet ON tb_paket.id_outlet = tb_outlet.id WHERE tb_paket.nama_paket LIKE '%" + txtSearch.Text + "%'" +
                           "OR tb_paket.harga LIKE '%" + txtSearch.Text + "%' OR tb_outlet.nama LIKE '%" + txtSearch.Text + "%' OR tb_jenis.jenis LIKE '%" + txtSearch.Text + "%'";

            DataTable data = Db.Read(query);
            dataTbPaket.AutoGenerateColumns = false;
            dataTbPaket.DataSource = data;
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
    }
}
