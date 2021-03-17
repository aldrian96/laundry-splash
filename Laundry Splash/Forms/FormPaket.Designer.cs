
namespace Laundry_Splash.Forms
{
    partial class FormPaket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaket));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaButtonAdd = new Guna.UI.WinForms.GunaButton();
            this.dataTbPaket = new Guna.UI.WinForms.GunaDataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPaket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idJenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOutlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.gunaButtonSearch = new Guna.UI.WinForms.GunaButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButtonEdit = new Guna.UI.WinForms.GunaButton();
            this.gunaButtonDelete = new Guna.UI.WinForms.GunaButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTbPaket)).BeginInit();
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
            this.gunaButtonAdd.TabIndex = 62;
            this.gunaButtonAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButtonAdd.Click += new System.EventHandler(this.gunaButtonAdd_Click);
            // 
            // dataTbPaket
            // 
            this.dataTbPaket.AllowUserToAddRows = false;
            this.dataTbPaket.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataTbPaket.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTbPaket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTbPaket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTbPaket.BackgroundColor = System.Drawing.Color.White;
            this.dataTbPaket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTbPaket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataTbPaket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTbPaket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTbPaket.ColumnHeadersHeight = 50;
            this.dataTbPaket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.namaPaket,
            this.idJenis,
            this.idOutlet,
            this.ColumnHarga});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTbPaket.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTbPaket.EnableHeadersVisualStyles = false;
            this.dataTbPaket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTbPaket.Location = new System.Drawing.Point(26, 79);
            this.dataTbPaket.Name = "dataTbPaket";
            this.dataTbPaket.ReadOnly = true;
            this.dataTbPaket.RowHeadersVisible = false;
            this.dataTbPaket.RowHeadersWidth = 51;
            this.dataTbPaket.RowTemplate.Height = 24;
            this.dataTbPaket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTbPaket.Size = new System.Drawing.Size(737, 289);
            this.dataTbPaket.TabIndex = 61;
            this.dataTbPaket.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataTbPaket.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTbPaket.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataTbPaket.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataTbPaket.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataTbPaket.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataTbPaket.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataTbPaket.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTbPaket.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.dataTbPaket.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataTbPaket.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTbPaket.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTbPaket.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataTbPaket.ThemeStyle.HeaderStyle.Height = 50;
            this.dataTbPaket.ThemeStyle.ReadOnly = true;
            this.dataTbPaket.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTbPaket.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataTbPaket.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTbPaket.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTbPaket.ThemeStyle.RowsStyle.Height = 24;
            this.dataTbPaket.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.AliceBlue;
            this.dataTbPaket.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTbPaket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTbPaket_CellClick);
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
            // namaPaket
            // 
            this.namaPaket.DataPropertyName = "nama_paket";
            this.namaPaket.HeaderText = "Nama Paket";
            this.namaPaket.MinimumWidth = 6;
            this.namaPaket.Name = "namaPaket";
            this.namaPaket.ReadOnly = true;
            // 
            // idJenis
            // 
            this.idJenis.DataPropertyName = "jenis";
            this.idJenis.HeaderText = "Jenis";
            this.idJenis.MinimumWidth = 6;
            this.idJenis.Name = "idJenis";
            this.idJenis.ReadOnly = true;
            // 
            // idOutlet
            // 
            this.idOutlet.DataPropertyName = "nama";
            this.idOutlet.HeaderText = "Outlet";
            this.idOutlet.MinimumWidth = 6;
            this.idOutlet.Name = "idOutlet";
            this.idOutlet.ReadOnly = true;
            // 
            // ColumnHarga
            // 
            this.ColumnHarga.DataPropertyName = "harga";
            this.ColumnHarga.HeaderText = "Harga";
            this.ColumnHarga.MinimumWidth = 6;
            this.ColumnHarga.Name = "ColumnHarga";
            this.ColumnHarga.ReadOnly = true;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this.dataTbPaket;
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
            this.btnRefresh.TabIndex = 68;
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
            this.gunaButtonSearch.TabIndex = 67;
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
            this.txtSearch.TabIndex = 66;
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
            this.gunaButtonEdit.TabIndex = 64;
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
            this.gunaButtonDelete.TabIndex = 63;
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
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // FormPaket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaButtonAdd);
            this.Controls.Add(this.dataTbPaket);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gunaButtonSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gunaButtonEdit);
            this.Controls.Add(this.gunaButtonDelete);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPaket";
            this.Text = "Produk";
            this.Load += new System.EventHandler(this.FormProduk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTbPaket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButtonAdd;
        private Guna.UI.WinForms.GunaDataGridView dataTbPaket;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaButton gunaButtonSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaButton gunaButtonEdit;
        private Guna.UI.WinForms.GunaButton gunaButtonDelete;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPaket;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOutlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHarga;
    }
}