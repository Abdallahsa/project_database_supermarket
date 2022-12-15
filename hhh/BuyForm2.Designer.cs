namespace hhh
{
    partial class BuyForm2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new hhh.masterDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qunatity = new System.Windows.Forms.TextBox();
            this.productTableAdapter = new hhh.masterDataSetTableAdapters.ProductTableAdapter();
            this.proID = new System.Windows.Forms.TextBox();
            this.proName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodIdDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn,
            this.prodPriceDataGridViewTextBoxColumn,
            this.prodQuantityDataGridViewTextBoxColumn,
            this.cateIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(358, 298);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(693, 241);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // prodIdDataGridViewTextBoxColumn
            // 
            this.prodIdDataGridViewTextBoxColumn.DataPropertyName = "ProdId";
            this.prodIdDataGridViewTextBoxColumn.HeaderText = "ProdId";
            this.prodIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodIdDataGridViewTextBoxColumn.Name = "prodIdDataGridViewTextBoxColumn";
            this.prodIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodPriceDataGridViewTextBoxColumn
            // 
            this.prodPriceDataGridViewTextBoxColumn.DataPropertyName = "ProdPrice";
            this.prodPriceDataGridViewTextBoxColumn.HeaderText = "ProdPrice";
            this.prodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodPriceDataGridViewTextBoxColumn.Name = "prodPriceDataGridViewTextBoxColumn";
            this.prodPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodQuantityDataGridViewTextBoxColumn
            // 
            this.prodQuantityDataGridViewTextBoxColumn.DataPropertyName = "ProdQuantity";
            this.prodQuantityDataGridViewTextBoxColumn.HeaderText = "ProdQuantity";
            this.prodQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodQuantityDataGridViewTextBoxColumn.Name = "prodQuantityDataGridViewTextBoxColumn";
            this.prodQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // cateIdDataGridViewTextBoxColumn
            // 
            this.cateIdDataGridViewTextBoxColumn.DataPropertyName = "CateId";
            this.cateIdDataGridViewTextBoxColumn.HeaderText = "CateId";
            this.cateIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cateIdDataGridViewTextBoxColumn.Name = "cateIdDataGridViewTextBoxColumn";
            this.cateIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(894, 185);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 41);
            this.button4.TabIndex = 13;
            this.button4.Text = "Show Prudect";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pro.Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cuatity";
            // 
            // qunatity
            // 
            this.qunatity.Location = new System.Drawing.Point(172, 107);
            this.qunatity.Margin = new System.Windows.Forms.Padding(4);
            this.qunatity.Name = "qunatity";
            this.qunatity.Size = new System.Drawing.Size(180, 22);
            this.qunatity.TabIndex = 18;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // proID
            // 
            this.proID.Location = new System.Drawing.Point(172, 23);
            this.proID.Margin = new System.Windows.Forms.Padding(4);
            this.proID.Name = "proID";
            this.proID.Size = new System.Drawing.Size(180, 22);
            this.proID.TabIndex = 23;
            // 
            // proName
            // 
            this.proName.Location = new System.Drawing.Point(845, 22);
            this.proName.Name = "proName";
            this.proName.Size = new System.Drawing.Size(171, 22);
            this.proName.TabIndex = 24;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(690, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(123, 20);
            this.name.TabIndex = 25;
            this.name.Text = "product name";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(811, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 59);
            this.button2.TabIndex = 26;
            this.button2.Text = "search id by name";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BuyForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.proName);
            this.Controls.Add(this.proID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qunatity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuyForm2";
            this.Text = "BuyForm2";
            this.Load += new System.EventHandler(this.BuyForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox qunatity;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private masterDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox proID;
        private System.Windows.Forms.TextBox proName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button button2;
    }
}