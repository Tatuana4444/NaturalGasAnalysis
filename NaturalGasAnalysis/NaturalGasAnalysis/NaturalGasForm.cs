using Microsoft.ML;
using Microsoft.ML.Transforms.TimeSeries;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NaturalGasAnalysis
{
    public partial class NaturalGasForm : Form
    {
        private MLContext mlContext = new MLContext(seed: 0);
        private SsaForecastingTransformer model;

        public NaturalGasForm()
        {
            InitializeComponent();
            GasChart.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM-yyyy";
            GasChart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            GasChart.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            GasChart.ChartAreas[0].AxisX.IsLabelAutoFit = false;

            for (int i = 0; i < 4; i++)
            {
                GasChart.Series[i].XValueType = ChartValueType.DateTime;
            }

            UpdateDateTimePicker();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            for(int i=0; i<4; i++)
            {
                GasChart.Series[i].Points.Clear();
            }
            
            DateTime startDate = startDateTimePicker.Value;
            DateTime endDate = endDateTimePicker.Value;
            DrawChart(startDate, endDate);
        }

        private void DrawChart(DateTime startDate, DateTime endDate)
        {
            using (NaturalGasEntities db = new NaturalGasEntities())
            {
                
                if (model is null)
                {
                    model = Prediction.Train(mlContext, db.NaruralGasPrice.Take(2000).ToList());
                }

                List<NaruralGasPrice> realDate = db.NaruralGasPrice.Where(s => s.Date >= startDate && s.Date <= endDate).ToList();

                for (int i = 0; i < realDate.Count; i++)
                {
                    if (realDataCheckBox.Checked)
                    {
                        GasChart.Series[0].Points.AddXY(realDate[i].Date, realDate[i].GasPrice);
                    }

                    var forecast = Prediction.Forecast(mlContext, model, realDate[i]);

                    if (lowerBoundCheckBox.Checked)
                    {
                        GasChart.Series[3].Points.AddXY(realDate[i].Date, forecast.LowerBoundPrice.First());
                    }

                    if (forecastCheckBox.Checked)
                    {
                        GasChart.Series[2].Points.AddXY(realDate[i].Date, forecast.ForecastedPrice.First());
                    }

                    if (upperBoundCheckBox.Checked)
                    {
                        GasChart.Series[1].Points.AddXY(realDate[i].Date, forecast.UpperBoundPrice.First());
                    }
                }
            }
        }

        private void FillDataBase(NaruralGasPrice[] prices)
        {
            foreach(var price in prices)
            {
                try
                {
                    using (NaturalGasEntities db = new NaturalGasEntities())
                    {
                        if (db.NaruralGasPrice.Where(s => s.Date == price.Date).FirstOrDefault() == null)
                        {
                            if (price != null)
                            {
                                db.NaruralGasPrice.Add(price);
                                db.SaveChanges();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private NaruralGasPrice[] GetNaruralGasPrices()
        {
            string naturalGasData = NaturalGasLoader.GetNaturalGasObject(ConfigurationManager.ConnectionStrings["NaturalGasUri"].ConnectionString);
           return JsonSerializer.Deserialize<NaruralGasPrice[]>(naturalGasData.ToString());
        }

        private void NaturalGasForm_Load(object sender, EventArgs e)
        {
            this.naruralGasPriceTableAdapter.Fill(this.naturalGasDataSet.NaruralGasPrice);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NaruralGasPrice[] prices = GetNaruralGasPrices();
            
            FillDataBase(prices);
            UpdateDateTimePicker();
            if (chartViewToolStripMenuItem.Checked)
            {
                tableViewToolStripMenuItem_Click(sender, e);
            }
            else
            {
                chartViewToolStripMenuItem_Click(sender, e);
            }

            using (NaturalGasEntities db = new NaturalGasEntities())
            {
                model = Prediction.Train(mlContext, db.NaruralGasPrice);
            }
        }

        private void UpdateDateTimePicker()
        {
            
            DateTime minDate = DateTime.Now, maxDate = DateTime.Now;
            using (NaturalGasEntities db = new NaturalGasEntities())
            {
                if (db.NaruralGasPrice.Count() > 0) 
                {
                    minDate = db.NaruralGasPrice.Min(s => s.Date);
                    maxDate = db.NaruralGasPrice.Max(s => s.Date);
                    runButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("There are no data!");
                    runButton.Enabled = false;
                }
            }

            startDateTimePicker.MinDate = minDate;
            startDateTimePicker.MaxDate = maxDate;
            endDateTimePicker.MinDate = minDate;
            endDateTimePicker.MaxDate = maxDate;
        }

        private void tableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartViewToolStripMenuItem.Checked = false;
            tableViewToolStripMenuItem.Checked = true;
            startDateTimePicker.Visible = false;
            endDateTimePicker.Visible = false;
            GasChart.Visible = false;
            gasDataGridView.Visible = true;
            realDataCheckBox.Visible = false;
            upperBoundCheckBox.Visible = false;
            forecastCheckBox.Visible = false;
            lowerBoundCheckBox.Visible = false;
            runButton.Visible = false;
            toLabel.Visible = false;
            fromLabel.Visible = false;
            NaturalGasForm_Load(sender, e);
        }

        private void chartViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartViewToolStripMenuItem.Checked = true;
            tableViewToolStripMenuItem.Checked = false;
            startDateTimePicker.Visible = true;
            endDateTimePicker.Visible = true;
            GasChart.Visible = true;
            gasDataGridView.Visible = false;
            realDataCheckBox.Visible = true;
            upperBoundCheckBox.Visible = true;
            forecastCheckBox.Visible = true;
            lowerBoundCheckBox.Visible = true;
            runButton.Visible = true;
            toLabel.Visible = true;
            fromLabel.Visible = true;
            runButton_Click(sender, e);
        }
    }
}
