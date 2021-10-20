using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NaturalGasAnalysis
{
    public static class NaturalGasLoader
    {
        public const string NaturalGasUri = @"https://pkgstore.datahub.io/core/natural-gas/daily_csv_preview/data/2c769d617c9d5e0699284c95ef9aa077/daily_csv_preview.json";

        public static string GetNaturalGasObject()
        {
            HttpClient httpClient = new HttpClient();

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(NaturalGasUri).Result;

                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    return result;
                }
                else
                {
                    throw new HtmlWebException("Can't load informtion");
                }
            }
            finally
            {
                httpClient.Dispose();
            }
        }
    }
}
