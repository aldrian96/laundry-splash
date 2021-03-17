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


namespace Laundry_Splash
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
        }

        //Method
        private Color SelectThemeColor()
        {
            string color = "#00adb5";
            return ColorTranslator.FromHtml(color);

            // Random Color
            /*int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];*/
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitlebar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType()== typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnRegistrasi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormRegistrasi(), sender);
        }

        private void btnOutlet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOutlet(), sender);
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPaket(), sender);
        }

        private void btnPengguna_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUser(), sender);
        }
        private void btnJenis_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormJenis(), sender);
        }
        private void btnTransaksi_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTransaksi(), sender);
        }

        private void btnLaporan_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLaporan(), sender);
        }

        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin logout?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Auth.Logout();
                this.Hide();
                Form login = new FormLogin();
                login.Show();
            }
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitlebar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            if(Session.getUserLogged().Rows[0].Field<string>("role") != "admin")  // not admin
            {
                btnOutlet.Visible = false;
                btnProduk.Visible = false;
                btnPengguna.Visible = false;
                btnJenis.Visible = false;
            }
            if (Session.getUserLogged().Rows[0].Field<string>("role") == "owner") // owner
            {
                btnTransaksi.Visible = false;
                btnRegistrasi.Visible = false;

            }
        }

        
    }
}
