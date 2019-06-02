namespace QuanLyKhachSan.Layout
{
    partial class FormDichVu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDichVu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimkiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataDichVu = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mADICHVUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDICHVUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIATIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_DICHVU = new QuanLyKhachSan.DataSet_DICHVU();
            this.dICHVUTableAdapter = new QuanLyKhachSan.DataSet_DICHVUTableAdapters.DICHVUTableAdapter();
            this.btnChiTietDV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DICHVU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Controls.Add(this.txtTimkiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 7;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiem.BorderRadius = 0;
            this.btnTimkiem.ButtonText = "       Tìm kiếm";
            this.btnTimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimkiem.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimkiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimkiem.Iconimage = null;
            this.btnTimkiem.Iconimage_right = null;
            this.btnTimkiem.Iconimage_right_Selected = null;
            this.btnTimkiem.Iconimage_Selected = null;
            this.btnTimkiem.IconMarginLeft = 0;
            this.btnTimkiem.IconMarginRight = 0;
            this.btnTimkiem.IconRightVisible = true;
            this.btnTimkiem.IconRightZoom = 0D;
            this.btnTimkiem.IconVisible = true;
            this.btnTimkiem.IconZoom = 90D;
            this.btnTimkiem.IsTab = false;
            this.btnTimkiem.Location = new System.Drawing.Point(682, 14);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTimkiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTimkiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimkiem.selected = false;
            this.btnTimkiem.Size = new System.Drawing.Size(97, 22);
            this.btnTimkiem.TabIndex = 99;
            this.btnTimkiem.Text = "       Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Textcolor = System.Drawing.Color.White;
            this.btnTimkiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(520, 16);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(146, 20);
            this.txtTimkiem.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "DỊCH VỤ";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Thêm dịch vụ";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(21, 75);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(229, 40);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "Thêm dịch vụ";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bthemdichvu);
            // 
            // dataDichVu
            // 
            this.dataDichVu.AllowUserToAddRows = false;
            this.dataDichVu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDichVu.AutoGenerateColumns = false;
            this.dataDichVu.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataDichVu.ColumnHeadersHeight = 25;
            this.dataDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mADICHVUDataGridViewTextBoxColumn,
            this.tENDICHVUDataGridViewTextBoxColumn,
            this.gIATIENDataGridViewTextBoxColumn,
            this.dELDataGridViewCheckBoxColumn});
            this.dataDichVu.DataSource = this.dICHVUBindingSource;
            this.dataDichVu.DoubleBuffered = true;
            this.dataDichVu.EnableHeadersVisualStyles = false;
            this.dataDichVu.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataDichVu.HeaderForeColor = System.Drawing.Color.White;
            this.dataDichVu.Location = new System.Drawing.Point(21, 143);
            this.dataDichVu.Name = "dataDichVu";
            this.dataDichVu.ReadOnly = true;
            this.dataDichVu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataDichVu.Size = new System.Drawing.Size(758, 418);
            this.dataDichVu.TabIndex = 9;
            this.dataDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDichVu_CellClick);
            // 
            // mADICHVUDataGridViewTextBoxColumn
            // 
            this.mADICHVUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mADICHVUDataGridViewTextBoxColumn.DataPropertyName = "MADICHVU";
            this.mADICHVUDataGridViewTextBoxColumn.HeaderText = "Mã dịch vụ";
            this.mADICHVUDataGridViewTextBoxColumn.Name = "mADICHVUDataGridViewTextBoxColumn";
            this.mADICHVUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tENDICHVUDataGridViewTextBoxColumn
            // 
            this.tENDICHVUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tENDICHVUDataGridViewTextBoxColumn.DataPropertyName = "TENDICHVU";
            this.tENDICHVUDataGridViewTextBoxColumn.HeaderText = "Tên dịch vụ";
            this.tENDICHVUDataGridViewTextBoxColumn.Name = "tENDICHVUDataGridViewTextBoxColumn";
            this.tENDICHVUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gIATIENDataGridViewTextBoxColumn
            // 
            this.gIATIENDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gIATIENDataGridViewTextBoxColumn.DataPropertyName = "GIATIEN";
            this.gIATIENDataGridViewTextBoxColumn.HeaderText = "Giá tiền";
            this.gIATIENDataGridViewTextBoxColumn.Name = "gIATIENDataGridViewTextBoxColumn";
            this.gIATIENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dELDataGridViewCheckBoxColumn
            // 
            this.dELDataGridViewCheckBoxColumn.DataPropertyName = "DEL";
            this.dELDataGridViewCheckBoxColumn.HeaderText = "Đã ẩn";
            this.dELDataGridViewCheckBoxColumn.Name = "dELDataGridViewCheckBoxColumn";
            this.dELDataGridViewCheckBoxColumn.ReadOnly = true;
            this.dELDataGridViewCheckBoxColumn.Width = 50;
            // 
            // dICHVUBindingSource
            // 
            this.dICHVUBindingSource.DataMember = "DICHVU";
            this.dICHVUBindingSource.DataSource = this.dataSet_DICHVU;
            // 
            // dataSet_DICHVU
            // 
            this.dataSet_DICHVU.DataSetName = "DataSet_DICHVU";
            this.dataSet_DICHVU.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dICHVUTableAdapter
            // 
            this.dICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // btnChiTietDV
            // 
            this.btnChiTietDV.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btnChiTietDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btnChiTietDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChiTietDV.BorderRadius = 0;
            this.btnChiTietDV.ButtonText = "Xem Chi Tiết Dịch Vụ";
            this.btnChiTietDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiTietDV.DisabledColor = System.Drawing.Color.Gray;
            this.btnChiTietDV.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChiTietDV.Iconimage = null;
            this.btnChiTietDV.Iconimage_right = null;
            this.btnChiTietDV.Iconimage_right_Selected = null;
            this.btnChiTietDV.Iconimage_Selected = null;
            this.btnChiTietDV.IconMarginLeft = 0;
            this.btnChiTietDV.IconMarginRight = 0;
            this.btnChiTietDV.IconRightVisible = true;
            this.btnChiTietDV.IconRightZoom = 0D;
            this.btnChiTietDV.IconVisible = true;
            this.btnChiTietDV.IconZoom = 90D;
            this.btnChiTietDV.IsTab = false;
            this.btnChiTietDV.Location = new System.Drawing.Point(537, 75);
            this.btnChiTietDV.Name = "btnChiTietDV";
            this.btnChiTietDV.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.btnChiTietDV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.btnChiTietDV.OnHoverTextColor = System.Drawing.Color.White;
            this.btnChiTietDV.selected = false;
            this.btnChiTietDV.Size = new System.Drawing.Size(229, 40);
            this.btnChiTietDV.TabIndex = 10;
            this.btnChiTietDV.Text = "Xem Chi Tiết Dịch Vụ";
            this.btnChiTietDV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChiTietDV.Textcolor = System.Drawing.Color.White;
            this.btnChiTietDV.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietDV.Click += new System.EventHandler(this.btnChiTietDV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(456, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnChiTietDV);
            this.Controls.Add(this.dataDichVu);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.panel1);
            this.Name = "FormDichVu";
            this.Size = new System.Drawing.Size(800, 591);
            this.Load += new System.EventHandler(this.FormDichVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DICHVU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataDichVu;
        private System.Windows.Forms.BindingSource dICHVUBindingSource;
        private DataSet_DICHVU dataSet_DICHVU;
        private DataSet_DICHVUTableAdapters.DICHVUTableAdapter dICHVUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADICHVUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDICHVUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIATIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dELDataGridViewCheckBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton btnChiTietDV;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
