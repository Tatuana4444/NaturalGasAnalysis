namespace NaturalGasAnalysis
{
    partial class NaturalGasForm
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
            this.runButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.naturalGasDataSet = new NaturalGasAnalysis.NaturalGasDataSet();
            this.naruralGasPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.naruralGasPriceTableAdapter = new NaturalGasAnalysis.NaturalGasDataSetTableAdapters.NaruralGasPriceTableAdapter();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naturalGasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naruralGasPriceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(122, 43);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(570, 49);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "button1";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.naruralGasPriceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(122, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 316);
            this.dataGridView1.TabIndex = 1;
            // 
            // naturalGasDataSet
            // 
            this.naturalGasDataSet.DataSetName = "NaturalGasDataSet";
            this.naturalGasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // naruralGasPriceBindingSource
            // 
            this.naruralGasPriceBindingSource.DataMember = "NaruralGasPrice";
            this.naruralGasPriceBindingSource.DataSource = this.naturalGasDataSet;
            // 
            // naruralGasPriceTableAdapter
            // 
            this.naruralGasPriceTableAdapter.ClearBeforeFill = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // NaturalGasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.runButton);
            this.Name = "NaturalGasForm";
            this.Text = "NaturalGasForm";
            this.Load += new System.EventHandler(this.NaturalGasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naturalGasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naruralGasPriceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NaturalGasDataSet naturalGasDataSet;
        private System.Windows.Forms.BindingSource naruralGasPriceBindingSource;
        private NaturalGasDataSetTableAdapters.NaruralGasPriceTableAdapter naruralGasPriceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}