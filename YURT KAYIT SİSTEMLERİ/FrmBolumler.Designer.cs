namespace YURT_KAYIT_SİSTEMLERİ
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.PcbBolumEkle = new System.Windows.Forms.PictureBox();
            this.PcbBolumSil = new System.Windows.Forms.PictureBox();
            this.PcbBolumDuzenle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBolumid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBolumAd = new System.Windows.Forms.TextBox();
            this.yURT_KAYITDataSet = new YURT_KAYIT_SİSTEMLERİ.YURT_KAYITDataSet();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yURT_KAYITDataSet1 = new YURT_KAYIT_SİSTEMLERİ.YURT_KAYITDataSet1();
            this.bolumlerTableAdapter = new YURT_KAYIT_SİSTEMLERİ.YURT_KAYITDataSetTableAdapters.BolumlerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumİDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yURT_KAYITDataSet2 = new YURT_KAYIT_SİSTEMLERİ.YURT_KAYITDataSet2();
            this.bolumlerTableAdapter1 = new YURT_KAYIT_SİSTEMLERİ.YURT_KAYITDataSet2TableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yURT_KAYITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yURT_KAYITDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yURT_KAYITDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbBolumEkle
            // 
            this.PcbBolumEkle.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumEkle.Image")));
            this.PcbBolumEkle.Location = new System.Drawing.Point(399, 50);
            this.PcbBolumEkle.Name = "PcbBolumEkle";
            this.PcbBolumEkle.Size = new System.Drawing.Size(56, 59);
            this.PcbBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbBolumEkle.TabIndex = 0;
            this.PcbBolumEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumEkle, "Bölüm Ekle");
            this.PcbBolumEkle.Click += new System.EventHandler(this.PcbBolumEkle_Click);
            // 
            // PcbBolumSil
            // 
            this.PcbBolumSil.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumSil.Image")));
            this.PcbBolumSil.Location = new System.Drawing.Point(484, 50);
            this.PcbBolumSil.Name = "PcbBolumSil";
            this.PcbBolumSil.Size = new System.Drawing.Size(63, 59);
            this.PcbBolumSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbBolumSil.TabIndex = 1;
            this.PcbBolumSil.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumSil, "Bölüm Sil");
            this.PcbBolumSil.Click += new System.EventHandler(this.PcbBolumSil_Click);
            // 
            // PcbBolumDuzenle
            // 
            this.PcbBolumDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("PcbBolumDuzenle.Image")));
            this.PcbBolumDuzenle.Location = new System.Drawing.Point(437, 115);
            this.PcbBolumDuzenle.Name = "PcbBolumDuzenle";
            this.PcbBolumDuzenle.Size = new System.Drawing.Size(62, 65);
            this.PcbBolumDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbBolumDuzenle.TabIndex = 2;
            this.PcbBolumDuzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.PcbBolumDuzenle, "Bölüm Güncelle");
            this.PcbBolumDuzenle.Click += new System.EventHandler(this.PcbBolumDuzenle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm id:";
            // 
            // TxtBolumid
            // 
            this.TxtBolumid.Enabled = false;
            this.TxtBolumid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumid.Location = new System.Drawing.Point(143, 50);
            this.TxtBolumid.Name = "TxtBolumid";
            this.TxtBolumid.Size = new System.Drawing.Size(202, 30);
            this.TxtBolumid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm Ad:";
            // 
            // TxtBolumAd
            // 
            this.TxtBolumAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBolumAd.Location = new System.Drawing.Point(143, 105);
            this.TxtBolumAd.Name = "TxtBolumAd";
            this.TxtBolumAd.Size = new System.Drawing.Size(202, 30);
            this.TxtBolumAd.TabIndex = 6;
            this.TxtBolumAd.Text = " ";
            // 
            // yURT_KAYITDataSet
            // 
            this.yURT_KAYITDataSet.DataSetName = "YURT_KAYITDataSet";
            this.yURT_KAYITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yURT_KAYITDataSet;
            // 
            // yURT_KAYITDataSet1
            // 
            this.yURT_KAYITDataSet1.DataSetName = "YURT_KAYITDataSet1";
            this.yURT_KAYITDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumİDDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 278);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumİDDataGridViewTextBoxColumn
            // 
            this.bolumİDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumİDDataGridViewTextBoxColumn.DataPropertyName = "BolumİD";
            this.bolumİDDataGridViewTextBoxColumn.HeaderText = "BolumİD";
            this.bolumİDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumİDDataGridViewTextBoxColumn.Name = "bolumİDDataGridViewTextBoxColumn";
            this.bolumİDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            this.bolumAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // bolumlerBindingSource1
            // 
            this.bolumlerBindingSource1.DataMember = "Bolumler";
            this.bolumlerBindingSource1.DataSource = this.yURT_KAYITDataSet2;
            // 
            // yURT_KAYITDataSet2
            // 
            this.yURT_KAYITDataSet2.DataSetName = "YURT_KAYITDataSet2";
            this.yURT_KAYITDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter1
            // 
            this.bolumlerTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(635, 490);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtBolumAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBolumid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PcbBolumDuzenle);
            this.Controls.Add(this.PcbBolumSil);
            this.Controls.Add(this.PcbBolumEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "Bolumler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBolumDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yURT_KAYITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yURT_KAYITDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yURT_KAYITDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbBolumEkle;
        private System.Windows.Forms.PictureBox PcbBolumSil;
        private System.Windows.Forms.PictureBox PcbBolumDuzenle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBolumid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBolumAd;
        private YURT_KAYITDataSet yURT_KAYITDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YURT_KAYITDataSet1 yURT_KAYITDataSet1;
        private YURT_KAYITDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YURT_KAYITDataSet2 yURT_KAYITDataSet2;
        private System.Windows.Forms.BindingSource bolumlerBindingSource1;
        private YURT_KAYITDataSet2TableAdapters.BolumlerTableAdapter bolumlerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumİDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}