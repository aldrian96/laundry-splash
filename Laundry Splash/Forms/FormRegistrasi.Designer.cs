
namespace Laundry_Splash.Forms
{
    partial class FormRegistrasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrasi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaButtonAdd = new Guna.UI.WinForms.GunaButton();
            this.dataTbPelanggan = new Guna.UI.WinForms.GunaDataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAlamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelepon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.gunaButtonSearch = new Guna.UI.WinForms.GunaButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButtonEdit = new Guna.UI.WinForms.GunaButton();
            this.gunaButtonDelete = new Guna.UI.WinForms.GunaButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTbPelanggan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaButtonAdd
            // 
            this.gunaButtonAdd.AnimationHoverSpeed = 0.07F;
            this.gunaButtonAdd.AnimationSpeed = 0.03F;
            this.gunaButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonAdd.BaseColor = System.Drawing.Color.ForestGreen;
            this.gunaButtonAdd.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonAdd.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButtonAdd.ForeColor = System.Drawing.Color.White;
            this.gunaButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonAdd.Image")));
            this.gunaButtonAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonAdd.Location = new System.Drawing.Point(26, 18);
            this.gunaButtonAdd.Name = "gunaButtonAdd";
            this.gunaButtonAdd.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.gunaButtonAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonAdd.OnHoverImage = null;
            this.gunaButtonAdd.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonAdd.Radius = 8;
            this.gunaButtonAdd.Size = new System.Drawing.Size(60, 55);
            this.gunaButtonAdd.TabIndex = 54;
            this.gunaButtonAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonAdd.Click += new System.EventHandler(this.gunaButtonAdd_Click);
            // 
            // dataTbPelanggan
            // 
            this.dataTbPelanggan.AllowUserToAddRows = false;
            this.dataTbPelanggan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataTbPelanggan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTbPelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTbPelanggan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTbPelanggan.BackgroundColor = System.Drawing.Color.White;
            this.dataTbPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTbPelanggan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataTbPelanggan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTbPelanggan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTbPelanggan.ColumnHeadersHeight = 50;
            this.dataTbPelanggan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNama,
            this.ColumnAlamat,
            this.ColumnJK,
            this.ColumnTelepon});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTbPelanggan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTbPelanggan.EnableHeadersVisualStyles = false;
            this.dataTbPelanggan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTbPelanggan.Location = new System.Drawing.Point(26, 79);
            this.dataTbPelanggan.Name = "dataTbPelanggan";
            this.dataTbPelanggan.ReadOnly = true;
            this.dataTbPelanggan.RowHeadersVisible = false;
            this.dataTbPelanggan.RowHeadersWidth = 51;
            this.dataTbPelanggan.RowTemplate.Height = 24;
            this.dataTbPelanggan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTbPelanggan.Size = new System.Drawing.Size(737, 289);
            this.dataTbPelanggan.TabIndex = 53;
            this.dataTbPelanggan.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataTbPelanggan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTbPelanggan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataTbPelanggan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataTbPelanggan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataTbPelanggan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataTbPelanggan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataTbPelanggan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTbPelanggan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.dataTbPelanggan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataTbPelanggan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTbPelanggan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTbPelanggan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataTbPelanggan.ThemeStyle.HeaderStyle.Height = 50;
            this.dataTbPelanggan.ThemeStyle.ReadOnly = true;
            this.dataTbPelanggan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTbPelanggan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataTbPelanggan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTbPelanggan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTbPelanggan.ThemeStyle.RowsStyle.Height = 24;
            this.dataTbPelanggan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.AliceBlue;
            this.dataTbPelanggan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTbPelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTbPelanggan_CellClick);
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "id";
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnNama
            // 
            this.ColumnNama.DataPropertyName = "nama";
            this.ColumnNama.HeaderText = "Nama";
            this.ColumnNama.MinimumWidth = 6;
            this.ColumnNama.Name = "ColumnNama";
            this.ColumnNama.ReadOnly = true;
            // 
            // ColumnAlamat
            // 
            this.ColumnAlamat.DataPropertyName = "alamat";
            this.ColumnAlamat.HeaderText = "Alamat";
            this.ColumnAlamat.MinimumWidth = 6;
            this.ColumnAlamat.Name = "ColumnAlamat";
            this.ColumnAlamat.ReadOnly = true;
            // 
            // ColumnJK
            // 
            this.ColumnJK.DataPropertyName = "jenis_kelamin";
            this.ColumnJK.HeaderText = "Jenis Kelamin";
            this.ColumnJK.MinimumWidth = 6;
            this.ColumnJK.Name = "ColumnJK";
            this.ColumnJK.ReadOnly = true;
            // 
            // ColumnTelepon
            // 
            this.ColumnTelepon.DataPropertyName = "tlp";
            this.ColumnTelepon.HeaderText = "No Telepon";
            this.ColumnTelepon.MinimumWidth = 6;
            this.ColumnTelepon.Name = "ColumnTelepon";
            this.ColumnTelepon.ReadOnly = true;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this.dataTbPelanggan;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AnimationHoverSpeed = 0.07F;
            this.btnRefresh.AnimationSpeed = 0.03F;
            this.btnRefresh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.FocusedColor = System.Drawing.Color.Empty;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRefresh.Location = new System.Drawing.Point(665, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 60;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gunaButtonSearch
            // 
            this.gunaButtonSearch.AnimationHoverSpeed = 0.07F;
            this.gunaButtonSearch.AnimationSpeed = 0.03F;
            this.gunaButtonSearch.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonSearch.BaseColor = System.Drawing.Color.Khaki;
            this.gunaButtonSearch.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonSearch.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButtonSearch.ForeColor = System.Drawing.Color.White;
            this.gunaButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonSearch.Image")));
            this.gunaButtonSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonSearch.Location = new System.Drawing.Point(224, 18);
            this.gunaButtonSearch.Name = "gunaButtonSearch";
            this.gunaButtonSearch.OnHoverBaseColor = System.Drawing.Color.Yellow;
            this.gunaButtonSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonSearch.OnHoverImage = null;
            this.gunaButtonSearch.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonSearch.Radius = 8;
            this.gunaButtonSearch.Size = new System.Drawing.Size(60, 55);
            this.gunaButtonSearch.TabIndex = 59;
            this.gunaButtonSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonSearch.Click += new System.EventHandler(this.gunaButtonSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.DimGray;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.SystemColors.Highlight;
            this.txtSearch.FocusedForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtSearch.Location = new System.Drawing.Point(290, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 8;
            this.txtSearch.Size = new System.Drawing.Size(369, 55);
            this.txtSearch.TabIndex = 58;
            this.txtSearch.Text = "Cari";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // gunaButtonEdit
            // 
            this.gunaButtonEdit.AnimationHoverSpeed = 0.07F;
            this.gunaButtonEdit.AnimationSpeed = 0.03F;
            this.gunaButtonEdit.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonEdit.BaseColor = System.Drawing.SystemColors.Highlight;
            this.gunaButtonEdit.BorderColor = System.Drawing.Color.Black;
            this.gunaButtonEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonEdit.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButtonEdit.ForeColor = System.Drawing.Color.White;
            this.gunaButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonEdit.Image")));
            this.gunaButtonEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonEdit.Location = new System.Drawing.Point(158, 18);
            this.gunaButtonEdit.Name = "gunaButtonEdit";
            this.gunaButtonEdit.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaButtonEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonEdit.OnHoverImage = null;
            this.gunaButtonEdit.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonEdit.Radius = 8;
            this.gunaButtonEdit.Size = new System.Drawing.Size(60, 55);
            this.gunaButtonEdit.TabIndex = 56;
            this.gunaButtonEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonEdit.Click += new System.EventHandler(this.gunaButtonEdit_Click);
            // 
            // gunaButtonDelete
            // 
            this.gunaButtonDelete.AnimationHoverSpeed = 0.07F;
            this.gunaButtonDelete.AnimationSpeed = 0.03F;
            this.gunaButtonDelete.BackColor = System.Drawing.Color.Transparent;
            this.gunaButtonDelete.BaseColor = System.Drawing.Color.Brown;
            this.gunaButtonDelete.BorderColor = System.Drawing.Color.Aqua;
            this.gunaButtonDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButtonDelete.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButtonDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButtonDelete.ForeColor = System.Drawing.Color.White;
            this.gunaButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("gunaButtonDelete.Image")));
            this.gunaButtonDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButtonDelete.Location = new System.Drawing.Point(92, 18);
            this.gunaButtonDelete.Name = "gunaButtonDelete";
            this.gunaButtonDelete.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gunaButtonDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButtonDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButtonDelete.OnHoverImage = null;
            this.gunaButtonDelete.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButtonDelete.Radius = 8;
            this.gunaButtonDelete.Size = new System.Drawing.Size(60, 55);
            this.gunaButtonDelete.TabIndex = 55;
            this.gunaButtonDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonDelete.Click += new System.EventHandler(this.gunaButtonDelete_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 342);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // FormRegistrasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaButtonAdd);
            this.Controls.Add(this.dataTbPelanggan);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gunaButtonSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gunaButtonEdit);
            this.Controls.Add(this.gunaButtonDelete);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrasi";
            this.Text = "Registrasi";
            this.Load += new System.EventHandler(this.FormRegistrasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTbPelanggan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButtonAdd;
        private Guna.UI.WinForms.GunaDataGridView dataTbPelanggan;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaButton gunaButtonSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaButton gunaButtonEdit;
        private Guna.UI.WinForms.GunaButton gunaButtonDelete;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAlamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelepon;
    }
}