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
        public const string NaturalGasUri = @"https://pkgstore.datahub.io/core/natural-gas/daily_json/data/2e630ca50c39a1a3cf6c3aff57a1b132/daily_json.json";

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
