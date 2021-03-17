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
    public partial class FormAddQuantity : Form
    {
        Guna.UI.WinForms.GunaDataGridView tbTransaksi;
        string idPaket;
        string nama;
        int harga;
        public FormAddQuantity(string id, Guna.UI.WinForms.GunaDataGridView tb)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            tbTransaksi = tb;
            idPaket = id;
        }

        private void FormAddQuantity_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtQty.Text.Length > 0 && txtQty.Text != "0")
            {
                double total = Convert.ToDouble(txtQty.Text) * harga;
                tbTransaksi.Rows.Add(idPaket, nama, txtQty.Text, total);
                this.Hide();
            }
        }
    }
}
