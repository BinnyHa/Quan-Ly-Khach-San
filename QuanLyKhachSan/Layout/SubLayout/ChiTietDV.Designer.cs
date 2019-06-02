namespace QuanLyKhachSan.Layout.SubLayout
{
    partial class ChiTietDV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSDDV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.qLKSDataSet = new QuanLyKhachSan.QLKSDataSet();
            this.sUDUNGDICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUDUNGDICHVUTableAdapter = new QuanLyKhachSan.QLKSDataSetTableAdapters.SUDUNGDICHVUTableAdapter();
            this.mASDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATHUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mADICHVUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSUDUNGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONGIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSDDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUDUNGDICHVUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSDDV
            // 
            this.dataSDDV.AllowUserToAddRows = false;
            this.dataSDDV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataSDDV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataSDDV.AutoGenerateColumns = false;
            this.dataSDDV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataSDDV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSDDV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSDDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataSDDV.ColumnHeadersHeight = 25;
            this.dataSDDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASDDataGridViewTextBoxColumn,
            this.mATHUEDataGridViewTextBoxColumn,
            this.mADICHVUDataGridViewTextBoxColumn,
            this.nGAYSUDUNGDataGridViewTextBoxColumn,
            this.dONGIADataGridViewTextBoxColumn});
            this.dataSDDV.DataSource = this.sUDUNGDICHVUBindingSource;
            this.dataSDDV.DoubleBuffered = true;
            this.dataSDDV.EnableHeadersVisualStyles = false;
            this.dataSDDV.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataSDDV.HeaderForeColor = System.Drawing.Color.White;
            this.dataSDDV.Location = new System.Drawing.Point(12, 12);
            this.dataSDDV.Name = "dataSDDV";
            this.dataSDDV.ReadOnly = true;
            this.dataSDDV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataSDDV.Size = new System.Drawing.Size(767, 422);
            this.dataSDDV.TabIndex = 10;
            // 
            // qLKSDataSet
            // 
            this.qLKSDataSet.DataSetName = "QLKSDataSet";
            this.qLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sUDUNGDICHVUBindingSource
            // 
            this.sUDUNGDICHVUBindingSource.DataMember = "SUDUNGDICHVU";
            this.sUDUNGDICHVUBindingSource.DataSource = this.qLKSDataSet;
            // 
            // sUDUNGDICHVUTableAdapter
            // 
            this.sUDUNGDICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // mASDDataGridViewTextBoxColumn
            // 
            this.mASDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mASDDataGridViewTextBoxColumn.DataPropertyName = "MASD";
            this.mASDDataGridViewTextBoxColumn.HeaderText = "MASD";
            this.mASDDataGridViewTextBoxColumn.Name = "mASDDataGridViewTextBoxColumn";
            this.mASDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mATHUEDataGridViewTextBoxColumn
            // 
            this.mATHUEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mATHUEDataGridViewTextBoxColumn.DataPropertyName = "MATHUE";
            this.mATHUEDataGridViewTextBoxColumn.HeaderText = "MATHUE";
            this.mATHUEDataGridViewTextBoxColumn.Name = "mATHUEDataGridViewTextBoxColumn";
            this.mATHUEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mADICHVUDataGridViewTextBoxColumn
            // 
            this.mADICHVUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mADICHVUDataGridViewTextBoxColumn.DataPropertyName = "MADICHVU";
            this.mADICHVUDataGridViewTextBoxColumn.HeaderText = "MADICHVU";
            this.mADICHVUDataGridViewTextBoxColumn.Name = "mADICHVUDataGridViewTextBoxColumn";
            this.mADICHVUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYSUDUNGDataGridViewTextBoxColumn
            // 
            this.nGAYSUDUNGDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nGAYSUDUNGDataGridViewTextBoxColumn.DataPropertyName = "NGAYSUDUNG";
            this.nGAYSUDUNGDataGridViewTextBoxColumn.HeaderText = "NGAYSUDUNG";
            this.nGAYSUDUNGDataGridViewTextBoxColumn.Name = "nGAYSUDUNGDataGridViewTextBoxColumn";
            this.nGAYSUDUNGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dONGIADataGridViewTextBoxColumn
            // 
            this.dONGIADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dONGIADataGridViewTextBoxColumn.DataPropertyName = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.HeaderText = "DONGIA";
            this.dONGIADataGridViewTextBoxColumn.Name = "dONGIADataGridViewTextBoxColumn";
            this.dONGIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ChiTietDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataSDDV);
            this.Name = "ChiTietDV";
            this.Text = "ChiTietDV";
            this.Load += new System.EventHandler(this.ChiTietDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSDDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUDUNGDICHVUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataSDDV;
        private QLKSDataSet qLKSDataSet;
        private System.Windows.Forms.BindingSource sUDUNGDICHVUBindingSource;
        private QLKSDataSetTableAdapters.SUDUNGDICHVUTableAdapter sUDUNGDICHVUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATHUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mADICHVUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSUDUNGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dONGIADataGridViewTextBoxColumn;
    }
}