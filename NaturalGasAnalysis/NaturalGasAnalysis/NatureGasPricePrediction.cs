using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalGasAnalysis
{
    public class NatureGasPricePrediction
    {
        public float[] ForecastedPrice { get; set; }

        public float[] LowerBoundPrice { get; set; }

        public float[] UpperBoundPrice { get; set; }
    }
}
