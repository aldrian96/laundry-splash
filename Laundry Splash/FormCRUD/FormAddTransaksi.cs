using Laundry_Splash.Forms;
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
    public partial class FormAddTransaksi : Form
    {
        public FormAddTransaksi()
        {
            InitializeComponent();
        }

        private void FormAddTransaksi_Load(object sender, EventArgs e)
        {
            generateItem(Db.Read("tb_paket", "id, nama_paket", $"id_outlet = {Session.getUserLogged().Rows[0].Field<int>("id_outlet")}"));
        }

        private void gunaButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void generateItem(DataTable dt)
        {
            FLPaket.Controls.Clear();
            foreach (DataRow row in dt.Rows)
            {
                var item = new Guna.UI.WinForms.GunaTileButton
                {
                    Name = row.Field<int>("id").ToString(),
                    BaseColor = Color.FromArgb((47), (85), (184)),
                    OnHoverBaseColor = Color.FromArgb((47), (85), (160)),
                    OnPressedDepth = 0,
                    Image = Program.LoadImage(row.Field<string>("icon")),
                    ImageSize = new Size(48,48),
                    TextImageOffsetY = 10,
                    Width = 128,
                    Height = 100,
                    Text = row.Field<string>("nama_paket"),
                    Font = new Font(new FontFamily("Calibri"), 9)
                    //Radius = 8
                };
            }

        }
        public void functionItems(Object sender, EventArgs e)
        {
            var item = (sender as Guna.UI.WinForms.GunaTileButton);
            new FormAddQuantity(item.Name, tbKeranjang).ShowDialog();
        }

    }
}
