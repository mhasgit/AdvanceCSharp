using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CountrySubdivisions
{
    public class Country
    {
       
        public int Id { get; set; }
        public string Alpha2 { get; set; }
        public string Alpha3 { get; set; }
        public string CountryName { get; set; }
    }

    public class CountriesService
    {
        public List<Country> GetCountriesByLocale(string locale = "en", string contentType = "json")
        {
            var responseText = this.GetCountriesText(locale, contentType);

            List<Country> countries = null;
            if (contentType == "json")
            {
                countries = JsonConvert.DeserializeObject<List<Country>>(responseText);
            }
            else if (contentType == "xml")
            {
                // 
            }
            else if (contentType == "csv")
            {

            }
            else if (contentType == "sql")
            {
                //SqlConnection con = new SqlConnection("");
                //SqlCommand command = con.CreateCommand();
                //command.CommandText = responseText.ToString();
                //command.BeginExecuteNonQuery();
                // SqlConnection
                // SqlCommand
                // SqlDataReader, 
            }

            return countries;
        }

        private string GetCountriesText(string locale, string contentType)
        {
            string countriesJsonUrl = $"https://raw.githubusercontent.com/stefangabos/world_countries/master/data/countries/{locale}/countries.{contentType}";

            HttpWebRequest request = WebRequest.CreateHttp(countriesJsonUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string jsonResponse = reader.ReadToEnd();

            return jsonResponse;
        }

        private static string GetSupportedLocaleFromUser()
        {
            string[] supportedLocales = new[] { "en", "ar", "fr", "de" };

            string locale = string.Empty;
            do
            {
                Console.Write("Enter a locale option (en, ar, fr, de): ");
                locale = Console.ReadLine();
            }
            while (!supportedLocales.Contains(locale.Trim()));

            return locale;
        }

        void BasicHttpRequestResponse()
        {
            string locale = GetSupportedLocaleFromUser();

            string countriesJsonUrl = $"https://raw.githubusercontent.com/stefangabos/world_countries/master/data/countries/{locale}/countries.json";

            HttpWebRequest request = WebRequest.CreateHttp(countriesJsonUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string jsonResponse = reader.ReadToEnd();
            Console.WriteLine(jsonResponse);

        }
    }
}
