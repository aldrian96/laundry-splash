
namespace Laundry_Splash.FormCRUD
{
    partial class FormEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditUser));
            this.label3 = new System.Windows.Forms.Label();
            this.cbOutlet = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRole = new Guna.UI.WinForms.GunaComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.gunaButtonBack = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.gunaButtonHeadBar = new Guna.UI.WinForms.GunaButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(41, 399);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 50;
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
            this.cbOutlet.ForeColor = System.Drawing.Color.DarkGray;
            this.cbOutlet.FormattingEnabled = true;
            this.cbOutlet.Location = new System.Drawing.Point(41, 435);
            this.cbOutlet.Name = "cbOutlet";
            this.cbOutlet.OnHoverItemBaseColor = System.Drawing.SystemColors.Highlight;
            this.cbOutlet.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbOutlet.Size = new System.Drawing.Size(355, 31);
            this.cbOutlet.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(41, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "Role";
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
            this.cbRole.ForeColor = System.Drawing.Color.DarkGray;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "admin",
            "kasir",
            "owner"});
            this.cbRole.Location = new System.Drawing.Point(41, 354);
            this.cbRole.Name = "cbRole";
            this.cbRole.OnHoverItemBaseColor = System.Drawing.SystemColors.Highlight;
            this.cbRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbRole.Size = new System.Drawing.Size(355, 31);
            this.cbRole.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(42, 146);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 1);
            this.panel2.TabIndex = 44;
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
            this.txtNama.TabIndex = 36;
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
            this.txtUsername.TabIndex = 37;
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
            this.label5.TabIndex = 46;
            this.label5.Text = "Username";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(42, 225);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 1);
            this.panel3.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 546);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEdit.Location = new System.Drawing.Point(235, 490);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.Fuchsia;
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 8;
            this.btnEdit.Size = new System.Drawing.Size(160, 50);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.gunaButtonBack.TabIndex = 42;
            this.gunaButtonBack.Text = "Kembali";
            this.gunaButtonBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonBack.Click += new System.EventHandler(this.gunaButtonBack_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 8;
            this.gunaElipse1.TargetControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(38, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Nama";
            // 
            // gunaButtonHeadBar
            // 
            this.gunaButtonHeadBar.AnimationHoverSpeed = 0.07F;
            this.gunaButtonHeadBar.AnimationSpeed = 0.03F;
            this.gunaButtonHeadBar.BaseColor = System.Drawing.SystemColors.Highlight;
            this.gunaButtonHeadBar.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonHeadBar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonHeadBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButtonHeadBar.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonHeadBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButtonHeadBar.ForeColor = System.Drawing.Color.White;
            this.gunaButtonHeadBar.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonHeadBar.Image")));
            this.gunaButtonHeadBar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonHeadBar.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonHeadBar.Location = new System.Drawing.Point(0, 0);
            this.gunaButtonHeadBar.Name = "gunaButtonHeadBar";
            this.gunaButtonHeadBar.OnHoverBaseColor = System.Drawing.SystemColors.MenuHighlight;
            this.gunaButtonHeadBar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonHeadBar.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonHeadBar.OnHoverImage = null;
            this.gunaButtonHeadBar.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonHeadBar.Size = new System.Drawing.Size(435, 66);
            this.gunaButtonHeadBar.TabIndex = 35;
            this.gunaButtonHeadBar.Text = "Edit Data User";
            this.gunaButtonHeadBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaButtonHeadBar;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPassword.Location = new System.Drawing.Point(40, 267);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(354, 23);
            this.txtPassword.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(36, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(41, 298);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 1);
            this.panel1.TabIndex = 52;
            // 
            // FormEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 610);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbOutlet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gunaButtonBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gunaButtonHeadBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditUser";
            this.Load += new System.EventHandler(this.FormEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cbOutlet;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cbRole;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private Guna.UI.WinForms.GunaButton gunaButtonBack;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaButton gunaButtonHeadBar;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}