
namespace Laundry_Splash.FormCRUD
{
    partial class FormEditPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditPelanggan));
            this.txtJenisKelamin = new System.Windows.Forms.TextBox();
            this.rbPerempuan = new Guna.UI.WinForms.GunaRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaButtonBack = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.rbLakilaki = new Guna.UI.WinForms.GunaRadioButton();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditOutlet = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJenisKelamin
            // 
            this.txtJenisKelamin.BackColor = System.Drawing.SystemColors.Control;
            this.txtJenisKelamin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJenisKelamin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJenisKelamin.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtJenisKelamin.Location = new System.Drawing.Point(40, 282);
            this.txtJenisKelamin.Margin = new System.Windows.Forms.Padding(4);
            this.txtJenisKelamin.Name = "txtJenisKelamin";
            this.txtJenisKelamin.Size = new System.Drawing.Size(354, 23);
            this.txtJenisKelamin.TabIndex = 72;
            this.txtJenisKelamin.Text = "L";
            this.txtJenisKelamin.Visible = false;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.BaseColor = System.Drawing.SystemColors.Control;
            this.rbPerempuan.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbPerempuan.CheckedOnColor = System.Drawing.SystemColors.Highlight;
            this.rbPerempuan.FillColor = System.Drawing.Color.White;
            this.rbPerempuan.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerempuan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbPerempuan.Location = new System.Drawing.Point(40, 247);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(114, 25);
            this.rbPerempuan.TabIndex = 71;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.CheckedChanged += new System.EventHandler(this.rbPerempuan_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(36, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 70;
            this.label1.Text = "Jenis Kelamin";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(43, 367);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 1);
            this.panel3.TabIndex = 63;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 8;
            this.gunaElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 546);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
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
            this.gunaButtonBack.TabIndex = 62;
            this.gunaButtonBack.Text = "Kembali";
            this.gunaButtonBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonBack.Click += new System.EventHandler(this.gunaButtonBack_Click);
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
            this.gunaButton1.TabIndex = 56;
            this.gunaButton1.Text = "Edit Data Pelanggan";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaButton1;
            // 
            // rbLakilaki
            // 
            this.rbLakilaki.BaseColor = System.Drawing.SystemColors.Control;
            this.rbLakilaki.Checked = true;
            this.rbLakilaki.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbLakilaki.CheckedOnColor = System.Drawing.SystemColors.Highlight;
            this.rbLakilaki.FillColor = System.Drawing.Color.White;
            this.rbLakilaki.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLakilaki.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbLakilaki.Location = new System.Drawing.Point(40, 216);
            this.rbLakilaki.Name = "rbLakilaki";
            this.rbLakilaki.Size = new System.Drawing.Size(89, 25);
            this.rbLakilaki.TabIndex = 69;
            this.rbLakilaki.Text = "Laki-laki";
            this.rbLakilaki.CheckedChanged += new System.EventHandler(this.rbLakilaki_CheckedChanged);
            // 
            // txtTelepon
            // 
            this.txtTelepon.BackColor = System.Drawing.Color.White;
            this.txtTelepon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelepon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelepon.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTelepon.Location = new System.Drawing.Point(42, 412);
            this.txtTelepon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(354, 23);
            this.txtTelepon.TabIndex = 59;
            this.txtTelepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelepon_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(43, 443);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 1);
            this.panel1.TabIndex = 67;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(42, 146);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 1);
            this.panel2.TabIndex = 64;
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
            this.txtNama.TabIndex = 57;
            // 
            // txtAlamat
            // 
            this.txtAlamat.BackColor = System.Drawing.Color.White;
            this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlamat.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamat.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtAlamat.Location = new System.Drawing.Point(42, 336);
            this.txtAlamat.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(354, 23);
            this.txtAlamat.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(38, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 66;
            this.label5.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(39, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 68;
            this.label2.Text = "No. Telepon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(36, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 65;
            this.label6.Text = "Nama";
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(36, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 73;
            this.label3.Text = "Nama";
            // 
            // btnEditOutlet
            // 
            this.btnEditOutlet.AnimationHoverSpeed = 0.07F;
            this.btnEditOutlet.AnimationSpeed = 0.03F;
            this.btnEditOutlet.BackColor = System.Drawing.Color.Transparent;
            this.btnEditOutlet.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditOutlet.BorderColor = System.Drawing.Color.Black;
            this.btnEditOutlet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditOutlet.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditOutlet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditOutlet.ForeColor = System.Drawing.Color.White;
            this.btnEditOutlet.Image = ((System.Drawing.Image)(resources.GetObject("btnEditOutlet.Image")));
            this.btnEditOutlet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditOutlet.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditOutlet.Location = new System.Drawing.Point(237, 490);
            this.btnEditOutlet.Name = "btnEditOutlet";
            this.btnEditOutlet.OnHoverBaseColor = System.Drawing.Color.Fuchsia;
            this.btnEditOutlet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditOutlet.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditOutlet.OnHoverImage = null;
            this.btnEditOutlet.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditOutlet.Radius = 8;
            this.btnEditOutlet.Size = new System.Drawing.Size(160, 50);
            this.btnEditOutlet.TabIndex = 74;
            this.btnEditOutlet.Text = "Edit";
            this.btnEditOutlet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditOutlet.Click += new System.EventHandler(this.btnEditOutlet_Click);
            // 
            // FormEditPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 610);
            this.Controls.Add(this.btnEditOutlet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJenisKelamin);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaButtonBack);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.rbLakilaki);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "- ";
            this.Load += new System.EventHandler(this.FormEditPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJenisKelamin;
        private Guna.UI.WinForms.GunaRadioButton rbPerempuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton gunaButtonBack;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaRadioButton rbLakilaki;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton btnEditOutlet;
    }
}