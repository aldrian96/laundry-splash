
namespace Laundry_Splash.Forms
{
    partial class FormOutlet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOutlet));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddOutlet = new Guna.UI.WinForms.GunaButton();
            this.dataTbOutlet = new Guna.UI.WinForms.GunaDataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAlamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTlp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.gunaButtonSearch = new Guna.UI.WinForms.GunaButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnEditOutlet = new Guna.UI.WinForms.GunaButton();
            this.btnDeleteOutlet = new Guna.UI.WinForms.GunaButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTbOutlet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddOutlet
            // 
            this.btnAddOutlet.AnimationHoverSpeed = 0.07F;
            this.btnAddOutlet.AnimationSpeed = 0.03F;
            this.btnAddOutlet.BackColor = System.Drawing.Color.Transparent;
            this.btnAddOutlet.BaseColor = System.Drawing.Color.ForestGreen;
            this.btnAddOutlet.BorderColor = System.Drawing.Color.Black;
            this.btnAddOutlet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddOutlet.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddOutlet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOutlet.ForeColor = System.Drawing.Color.White;
            this.btnAddOutlet.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOutlet.Image")));
            this.btnAddOutlet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddOutlet.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddOutlet.Location = new System.Drawing.Point(26, 18);
            this.btnAddOutlet.Name = "btnAddOutlet";
            this.btnAddOutlet.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.btnAddOutlet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddOutlet.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddOutlet.OnHoverImage = null;
            this.btnAddOutlet.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddOutlet.Radius = 8;
            this.btnAddOutlet.Size = new System.Drawing.Size(60, 55);
            this.btnAddOutlet.TabIndex = 54;
            this.btnAddOutlet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddOutlet.Click += new System.EventHandler(this.btnAddOutlet_Click);
            // 
            // dataTbOutlet
            // 
            this.dataTbOutlet.AllowUserToAddRows = false;
            this.dataTbOutlet.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataTbOutlet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataTbOutlet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTbOutlet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTbOutlet.BackgroundColor = System.Drawing.Color.White;
            this.dataTbOutlet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTbOutlet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataTbOutlet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTbOutlet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataTbOutlet.ColumnHeadersHeight = 50;
            this.dataTbOutlet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNama,
            this.ColumnAlamat,
            this.ColumnTlp});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTbOutlet.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataTbOutlet.EnableHeadersVisualStyles = false;
            this.dataTbOutlet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTbOutlet.Location = new System.Drawing.Point(26, 79);
            this.dataTbOutlet.Name = "dataTbOutlet";
            this.dataTbOutlet.ReadOnly = true;
            this.dataTbOutlet.RowHeadersVisible = false;
            this.dataTbOutlet.RowHeadersWidth = 51;
            this.dataTbOutlet.RowTemplate.Height = 24;
            this.dataTbOutlet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTbOutlet.Size = new System.Drawing.Size(737, 289);
            this.dataTbOutlet.TabIndex = 53;
            this.dataTbOutlet.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataTbOutlet.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTbOutlet.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataTbOutlet.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataTbOutlet.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataTbOutlet.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataTbOutlet.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataTbOutlet.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTbOutlet.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.dataTbOutlet.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataTbOutlet.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTbOutlet.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTbOutlet.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataTbOutlet.ThemeStyle.HeaderStyle.Height = 50;
            this.dataTbOutlet.ThemeStyle.ReadOnly = true;
            this.dataTbOutlet.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTbOutlet.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataTbOutlet.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTbOutlet.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTbOutlet.ThemeStyle.RowsStyle.Height = 24;
            this.dataTbOutlet.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.AliceBlue;
            this.dataTbOutlet.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTbOutlet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTbOutlet_CellClick);
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
            // ColumnTlp
            // 
            this.ColumnTlp.DataPropertyName = "tlp";
            this.ColumnTlp.HeaderText = "No Telepon";
            this.ColumnTlp.MinimumWidth = 6;
            this.ColumnTlp.Name = "ColumnTlp";
            this.ColumnTlp.ReadOnly = true;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this.dataTbOutlet;
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
            this.btnRefresh.Location = new System.Drawing.Point(665, 29);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefresh.Size = new System.Drawing.Size(40, 33);
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
            // btnEditOutlet
            // 
            this.btnEditOutlet.AnimationHoverSpeed = 0.07F;
            this.btnEditOutlet.AnimationSpeed = 0.03F;
            this.btnEditOutlet.BackColor = System.Drawing.Color.Transparent;
            this.btnEditOutlet.BaseColor = System.Drawing.SystemColors.Highlight;
            this.btnEditOutlet.BorderColor = System.Drawing.Color.Black;
            this.btnEditOutlet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditOutlet.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditOutlet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOutlet.ForeColor = System.Drawing.Color.White;
            this.btnEditOutlet.Image = ((System.Drawing.Image)(resources.GetObject("btnEditOutlet.Image")));
            this.btnEditOutlet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditOutlet.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditOutlet.Location = new System.Drawing.Point(158, 18);
            this.btnEditOutlet.Name = "btnEditOutlet";
            this.btnEditOutlet.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditOutlet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditOutlet.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditOutlet.OnHoverImage = null;
            this.btnEditOutlet.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditOutlet.Radius = 8;
            this.btnEditOutlet.Size = new System.Drawing.Size(60, 55);
            this.btnEditOutlet.TabIndex = 56;
            this.btnEditOutlet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditOutlet.Click += new System.EventHandler(this.btnEditOutlet_Click);
            // 
            // btnDeleteOutlet
            // 
            this.btnDeleteOutlet.AnimationHoverSpeed = 0.07F;
            this.btnDeleteOutlet.AnimationSpeed = 0.03F;
            this.btnDeleteOutlet.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteOutlet.BaseColor = System.Drawing.Color.Brown;
            this.btnDeleteOutlet.BorderColor = System.Drawing.Color.Aqua;
            this.btnDeleteOutlet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteOutlet.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteOutlet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOutlet.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOutlet.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteOutlet.Image")));
            this.btnDeleteOutlet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteOutlet.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteOutlet.Location = new System.Drawing.Point(92, 18);
            this.btnDeleteOutlet.Name = "btnDeleteOutlet";
            this.btnDeleteOutlet.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnDeleteOutlet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDeleteOutlet.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteOutlet.OnHoverImage = null;
            this.btnDeleteOutlet.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteOutlet.Radius = 8;
            this.btnDeleteOutlet.Size = new System.Drawing.Size(60, 55);
            this.btnDeleteOutlet.TabIndex = 55;
            this.btnDeleteOutlet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteOutlet.Click += new System.EventHandler(this.btnDeleteOutlet_Click);
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
            // FormOutlet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddOutlet);
            this.Controls.Add(this.dataTbOutlet);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gunaButtonSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnEditOutlet);
            this.Controls.Add(this.btnDeleteOutlet);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOutlet";
            this.Text = "Outlet";
            this.Load += new System.EventHandler(this.FormOutlet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTbOutlet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnAddOutlet;
        private Guna.UI.WinForms.GunaDataGridView dataTbOutlet;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaButton gunaButtonSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaButton btnEditOutlet;
        private Guna.UI.WinForms.GunaButton btnDeleteOutlet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAlamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTlp;
    }
}