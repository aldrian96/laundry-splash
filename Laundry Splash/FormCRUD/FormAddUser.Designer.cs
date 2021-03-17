
namespace Laundry_Splash.FormCRUD
{
    partial class FormAddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUser));
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaButtonBack = new Guna.UI.WinForms.GunaButton();
            this.gunaButtonTambah = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRole = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOutlet = new Guna.UI.WinForms.GunaComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.labelKS = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.SystemColors.Highlight;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(0, 0);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(435, 66);
            this.gunaButton1.TabIndex = 0;
            this.gunaButton1.Text = "Tambah Data User";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 8;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaButtonBack
            // 
            this.gunaButtonBack.AnimationHoverSpeed = 0.07F;
            this.gunaButtonBack.AnimationSpeed = 0.03F;
            this.gunaButtonBack.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonBack.BaseColor = System.Drawing.SystemColors.Highlight;
            this.gunaButtonBack.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonBack.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButtonBack.ForeColor = System.Drawing.Color.White;
            this.gunaButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonBack.Image")));
            this.gunaButtonBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonBack.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonBack.Location = new System.Drawing.Point(40, 490);
            this.gunaButtonBack.Name = "gunaButtonBack";
            this.gunaButtonBack.OnHoverBaseColor = System.Drawing.Color.Aqua;
            this.gunaButtonBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonBack.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonBack.OnHoverImage = null;
            this.gunaButtonBack.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonBack.Radius = 8;
            this.gunaButtonBack.Size = new System.Drawing.Size(160, 50);
            this.gunaButtonBack.TabIndex = 7;
            this.gunaButtonBack.Text = "Kembali";
            this.gunaButtonBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonBack.Click += new System.EventHandler(this.gunaButtonBack_Click);
            // 
            // gunaButtonTambah
            // 
            this.gunaButtonTambah.AnimationHoverSpeed = 0.07F;
            this.gunaButtonTambah.AnimationSpeed = 0.03F;
            this.gunaButtonTambah.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonTambah.BaseColor = System.Drawing.Color.Green;
            this.gunaButtonTambah.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonTambah.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonTambah.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonTambah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButtonTambah.ForeColor = System.Drawing.Color.White;
            this.gunaButtonTambah.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonTambah.Image")));
            this.gunaButtonTambah.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonTambah.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonTambah.Location = new System.Drawing.Point(235, 490);
            this.gunaButtonTambah.Name = "gunaButtonTambah";
            this.gunaButtonTambah.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.gunaButtonTambah.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonTambah.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonTambah.OnHoverImage = null;
            this.gunaButtonTambah.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonTambah.Radius = 8;
            this.gunaButtonTambah.Size = new System.Drawing.Size(160, 50);
            this.gunaButtonTambah.TabIndex = 6;
            this.gunaButtonTambah.Text = "Tambah";
            this.gunaButtonTambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonTambah.Click += new System.EventHandler(this.gunaButtonTambah_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 546);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Location = new System.Drawing.Point(42, 146);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 1);
            this.panel2.TabIndex = 22;
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.Color.White;
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNama.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNama.Location = new System.Drawing.Point(41, 115);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(354, 23);
            this.txtNama.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtUsername.Location = new System.Drawing.Point(41, 194);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(354, 23);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(37, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(36, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Nama";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Location = new System.Drawing.Point(42, 315);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 1);
            this.panel1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(38, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Password";
            // 
            // cbRole
            // 
            this.cbRole.BackColor = System.Drawing.Color.Transparent;
            this.cbRole.BaseColor = System.Drawing.Color.White;
            this.cbRole.BorderColor = System.Drawing.Color.Silver;
            this.cbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FocusedColor = System.Drawing.Color.Empty;
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbRole.ForeColor = System.Drawing.Color.Gray;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "admin",
            "kasir",
            "owner"});
            this.cbRole.Location = new System.Drawing.Point(40, 360);
            this.cbRole.Name = "cbRole";
            this.cbRole.OnHoverItemBaseColor = System.Drawing.SystemColors.Highlight;
            this.cbRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbRole.Size = new System.Drawing.Size(355, 31);
            this.cbRole.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(40, 323);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(40, 405);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Outlet";
            // 
            // cbOutlet
            // 
            this.cbOutlet.BackColor = System.Drawing.Color.Transparent;
            this.cbOutlet.BaseColor = System.Drawing.Color.White;
            this.cbOutlet.BorderColor = System.Drawing.Color.Silver;
            this.cbOutlet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOutlet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutlet.FocusedColor = System.Drawing.Color.Empty;
            this.cbOutlet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbOutlet.ForeColor = System.Drawing.Color.Gray;
            this.cbOutlet.FormattingEnabled = true;
            this.cbOutlet.Location = new System.Drawing.Point(40, 441);
            this.cbOutlet.Name = "cbOutlet";
            this.cbOutlet.OnHoverItemBaseColor = System.Drawing.SystemColors.Highlight;
            this.cbOutlet.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbOutlet.Size = new System.Drawing.Size(355, 31);
            this.cbOutlet.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPassword.Location = new System.Drawing.Point(41, 284);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(354, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaButton1;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this;
            // 
            // labelKS
            // 
            this.labelKS.AutoSize = true;
            this.labelKS.BackColor = System.Drawing.Color.Transparent;
            this.labelKS.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKS.ForeColor = System.Drawing.Color.Red;
            this.labelKS.Location = new System.Drawing.Point(37, 230);
            this.labelKS.Name = "labelKS";
            this.labelKS.Size = new System.Drawing.Size(250, 17);
            this.labelKS.TabIndex = 34;
            this.labelKS.Text = "Username tidak boleh menggunakan Spasi!\r\n";
            this.labelKS.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Location = new System.Drawing.Point(42, 225);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 1);
            this.panel3.TabIndex = 21;
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 610);
            this.Controls.Add(this.labelKS);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbOutlet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaButtonTambah);
            this.Controls.Add(this.gunaButtonBack);
            this.Controls.Add(this.gunaButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddUser";
            this.Load += new System.EventHandler(this.FormAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton gunaButtonTambah;
        private Guna.UI.WinForms.GunaButton gunaButtonBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cbOutlet;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cbRole;
        private System.Windows.Forms.TextBox txtPassword;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private System.Windows.Forms.Label labelKS;
        private System.Windows.Forms.Panel panel3;
    }
}