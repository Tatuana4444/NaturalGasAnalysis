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
        public static string GetNaturalGasObject(string NaturalGasUri)
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
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                httpClient.Dispose();
            }
        }
    }
}
