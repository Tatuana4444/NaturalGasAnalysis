using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaturalGasAnalysis
{
    public partial class NaturalGasForm : Form
    {
        public NaturalGasForm()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string naturalGasData = NaturalGasLoader.GetNaturalGasObject();
            NaruralGasPrice[] prices = JsonSerializer.Deserialize<NaruralGasPrice[]>(naturalGasData);
            for (int i = 0; i < prices.Length; i++)
            {
                try
                {
                    using (NaturalGasEntities db = new NaturalGasEntities())
                    {
                        if (db.NaruralGasPrice.Find(prices[i].Date) == null)
                        {
                            db.NaruralGasPrice.Add(prices[i]);
                            db.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            NaturalGasForm_Load(sender, e);
        }

        private void NaturalGasForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'naturalGasDataSet.NaruralGasPrice' table. You can move, or remove it, as needed.
            this.naruralGasPriceTableAdapter.Fill(this.naturalGasDataSet.NaruralGasPrice);

        }
    }
}
