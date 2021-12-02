using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms.TimeSeries;


namespace NaturalGasAnalysis
{
    public class Prediction
    {
        public static SsaForecastingTransformer Train(MLContext mlContext, IEnumerable<NaturalGasPredict> inMemoryCollection)
        {
            SsaForecastingTransformer model;
            IDataView dataView = mlContext.Data.LoadFromEnumerable(inMemoryCollection);
            var forecastingPipeline = mlContext.Forecasting.ForecastBySsa(
                outputColumnName: nameof(NatureGasPricePrediction.ForecastedPrice),
                inputColumnName: nameof(NaturalGasPredict.GasPrice),
                windowSize: 7,
                seriesLength: 30,
                trainSize: 365,
                horizon: 1,
                confidenceLevel: 0.95f,
                confidenceLowerBoundColumn: nameof(NatureGasPricePrediction.LowerBoundPrice),
                confidenceUpperBoundColumn: nameof(NatureGasPricePrediction.UpperBoundPrice));

            model = forecastingPipeline.Fit(dataView);

            return model;
        }

        public static NatureGasPricePrediction Forecast(MLContext mlContext, SsaForecastingTransformer model, NaturalGasPredict features)
        {
            var predictionFunction = model.CreateTimeSeriesEngine<NaturalGasPredict, NatureGasPricePrediction>(mlContext);

            var prediction = predictionFunction.Predict(features);

            return prediction;
        }
    }
}
