
namespace Laundry_Splash.FormCRUD
{
    partial class FormAddJenis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddJenis));
            this.txtJenisPaket = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaButtonTambah = new Guna.UI.WinForms.GunaButton();
            this.gunaButtonBack = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJenisPaket
            // 
            this.txtJenisPaket.BackColor = System.Drawing.Color.White;
            this.txtJenisPaket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJenisPaket.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJenisPaket.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtJenisPaket.Location = new System.Drawing.Point(40, 128);
            this.txtJenisPaket.Margin = new System.Windows.Forms.Padding(4);
            this.txtJenisPaket.Name = "txtJenisPaket";
            this.txtJenisPaket.Size = new System.Drawing.Size(355, 23);
            this.txtJenisPaket.TabIndex = 56;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(40, 159);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 1);
            this.panel1.TabIndex = 63;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 8;
            this.gunaElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(36, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 64;
            this.label2.Text = "Jenis Paket";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 313);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
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
            this.gunaButtonTambah.Location = new System.Drawing.Point(235, 257);
            this.gunaButtonTambah.Name = "gunaButtonTambah";
            this.gunaButtonTambah.OnHoverBaseColor = System.Drawing.Color.Lime;
            this.gunaButtonTambah.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonTambah.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonTambah.OnHoverImage = null;
            this.gunaButtonTambah.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonTambah.Radius = 8;
            this.gunaButtonTambah.Size = new System.Drawing.Size(160, 50);
            this.gunaButtonTambah.TabIndex = 57;
            this.gunaButtonTambah.Text = "Tambah";
            this.gunaButtonTambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonTambah.Click += new System.EventHandler(this.gunaButtonTambah_Click);
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
            this.gunaButtonBack.Location = new System.Drawing.Point(40, 257);
            this.gunaButtonBack.Name = "gunaButtonBack";
            this.gunaButtonBack.OnHoverBaseColor = System.Drawing.Color.Aqua;
            this.gunaButtonBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonBack.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonBack.OnHoverImage = null;
            this.gunaButtonBack.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonBack.Radius = 6;
            this.gunaButtonBack.Size = new System.Drawing.Size(160, 50);
            this.gunaButtonBack.TabIndex = 60;
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
            this.gunaButton1.TabIndex = 58;
            this.gunaButton1.Text = "Tambah Jenis Paket";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaButton1;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = null;
            // 
            // FormAddJenis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 377);
            this.Controls.Add(this.txtJenisPaket);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaButtonTambah);
            this.Controls.Add(this.gunaButtonBack);
            this.Controls.Add(this.gunaButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddJenis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddJenis";
            this.Load += new System.EventHandler(this.FormAddJenis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtJenisPaket;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton gunaButtonTambah;
        private Guna.UI.WinForms.GunaButton gunaButtonBack;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
    }
}