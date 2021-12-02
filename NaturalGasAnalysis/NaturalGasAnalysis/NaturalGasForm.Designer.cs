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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.runButton = new System.Windows.Forms.Button();
            this.gasDataGridView = new System.Windows.Forms.DataGridView();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naruralGasPriceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.naturalGasDataSet = new NaturalGasAnalysis.NaturalGasDataSet();
            this.naruralGasPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GasChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.naruralGasPriceTableAdapter = new NaturalGasAnalysis.NaturalGasDataSetTableAdapters.NaruralGasPriceTableAdapter();
            this.realDataCheckBox = new System.Windows.Forms.CheckBox();
            this.upperBoundCheckBox = new System.Windows.Forms.CheckBox();
            this.forecastCheckBox = new System.Windows.Forms.CheckBox();
            this.lowerBoundCheckBox = new System.Windows.Forms.CheckBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naruralGasPriceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naturalGasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naruralGasPriceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GasChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(45, 462);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(200, 49);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Show";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // gasDataGridView
            // 
            this.gasDataGridView.AutoGenerateColumns = false;
            this.gasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.priceDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.gasDataGridView.DataSource = this.naruralGasPriceBindingSource1;
            this.gasDataGridView.Location = new System.Drawing.Point(242, 68);
            this.gasDataGridView.Name = "gasDataGridView";
            this.gasDataGridView.RowHeadersWidth = 51;
            this.gasDataGridView.RowTemplate.Height = 24;
            this.gasDataGridView.Size = new System.Drawing.Size(907, 392);
            this.gasDataGridView.TabIndex = 1;
            this.gasDataGridView.Visible = false;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // naruralGasPriceBindingSource1
            // 
            this.naruralGasPriceBindingSource1.DataMember = "NaruralGasPrice";
            this.naruralGasPriceBindingSource1.DataSource = this.naturalGasDataSet;
            // 
            // naturalGasDataSet
            // 
            this.naturalGasDataSet.DataSetName = "NaturalGasDataSet";
            this.naturalGasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // naruralGasPriceBindingSource
            // 
            this.naruralGasPriceBindingSource.DataMember = "NaruralGasPrice";
            // 
            // GasChart
            // 
            chartArea1.Name = "ChartArea1";
            this.GasChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GasChart.Legends.Add(legend1);
            this.GasChart.Location = new System.Drawing.Point(262, 50);
            this.GasChart.Name = "GasChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Real Price";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Upper Bound Price";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Foreacast Price";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Lower Bound Price";
            this.GasChart.Series.Add(series1);
            this.GasChart.Series.Add(series2);
            this.GasChart.Series.Add(series3);
            this.GasChart.Series.Add(series4);
            this.GasChart.Size = new System.Drawing.Size(1097, 484);
            this.GasChart.TabIndex = 2;
            this.GasChart.Text = "GasChart";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1406, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableViewToolStripMenuItem,
            this.chartViewToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // tableViewToolStripMenuItem
            // 
            this.tableViewToolStripMenuItem.Name = "tableViewToolStripMenuItem";
            this.tableViewToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.tableViewToolStripMenuItem.Text = "Table view";
            this.tableViewToolStripMenuItem.Click += new System.EventHandler(this.tableViewToolStripMenuItem_Click);
            // 
            // chartViewToolStripMenuItem
            // 
            this.chartViewToolStripMenuItem.Checked = true;
            this.chartViewToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chartViewToolStripMenuItem.Name = "chartViewToolStripMenuItem";
            this.chartViewToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.chartViewToolStripMenuItem.Text = "Chart view";
            this.chartViewToolStripMenuItem.Click += new System.EventHandler(this.chartViewToolStripMenuItem_Click);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(45, 74);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startDateTimePicker.TabIndex = 4;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(45, 139);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.endDateTimePicker.TabIndex = 5;
            // 
            // naruralGasPriceTableAdapter
            // 
            this.naruralGasPriceTableAdapter.ClearBeforeFill = true;
            // 
            // realDataCheckBox
            // 
            this.realDataCheckBox.AutoSize = true;
            this.realDataCheckBox.Location = new System.Drawing.Point(45, 205);
            this.realDataCheckBox.Name = "realDataCheckBox";
            this.realDataCheckBox.Size = new System.Drawing.Size(95, 21);
            this.realDataCheckBox.TabIndex = 6;
            this.realDataCheckBox.Text = "Real Price";
            this.realDataCheckBox.UseVisualStyleBackColor = true;
            // 
            // upperBoundCheckBox
            // 
            this.upperBoundCheckBox.AutoSize = true;
            this.upperBoundCheckBox.Location = new System.Drawing.Point(45, 249);
            this.upperBoundCheckBox.Name = "upperBoundCheckBox";
            this.upperBoundCheckBox.Size = new System.Drawing.Size(150, 21);
            this.upperBoundCheckBox.TabIndex = 7;
            this.upperBoundCheckBox.Text = "Upper Bound Price";
            this.upperBoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // forecastCheckBox
            // 
            this.forecastCheckBox.AutoSize = true;
            this.forecastCheckBox.Location = new System.Drawing.Point(45, 293);
            this.forecastCheckBox.Name = "forecastCheckBox";
            this.forecastCheckBox.Size = new System.Drawing.Size(121, 21);
            this.forecastCheckBox.TabIndex = 8;
            this.forecastCheckBox.Text = "Forecast Price";
            this.forecastCheckBox.UseVisualStyleBackColor = true;
            // 
            // lowerBoundCheckBox
            // 
            this.lowerBoundCheckBox.AutoSize = true;
            this.lowerBoundCheckBox.Location = new System.Drawing.Point(45, 340);
            this.lowerBoundCheckBox.Name = "lowerBoundCheckBox";
            this.lowerBoundCheckBox.Size = new System.Drawing.Size(149, 21);
            this.lowerBoundCheckBox.TabIndex = 9;
            this.lowerBoundCheckBox.Text = "Lower Bound Price";
            this.lowerBoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(42, 54);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(40, 17);
            this.toLabel.TabIndex = 10;
            this.toLabel.Text = "From";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(42, 119);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(25, 17);
            this.fromLabel.TabIndex = 11;
            this.fromLabel.Text = "To";
            // 
            // NaturalGasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 561);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.lowerBoundCheckBox);
            this.Controls.Add(this.forecastCheckBox);
            this.Controls.Add(this.upperBoundCheckBox);
            this.Controls.Add(this.realDataCheckBox);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.GasChart);
            this.Controls.Add(this.gasDataGridView);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NaturalGasForm";
            this.Text = "NaturalGasForm";
            this.Load += new System.EventHandler(this.NaturalGasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naruralGasPriceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naturalGasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naruralGasPriceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GasChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.DataGridView gasDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart GasChart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartViewToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.BindingSource naruralGasPriceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private NaturalGasDataSet naturalGasDataSet;
        private System.Windows.Forms.BindingSource naruralGasPriceBindingSource1;
        private NaturalGasDataSetTableAdapters.NaruralGasPriceTableAdapter naruralGasPriceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naturalGasPriceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.CheckBox realDataCheckBox;
        private System.Windows.Forms.CheckBox upperBoundCheckBox;
        private System.Windows.Forms.CheckBox forecastCheckBox;
        private System.Windows.Forms.CheckBox lowerBoundCheckBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
    }
}