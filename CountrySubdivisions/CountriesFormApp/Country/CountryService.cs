using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Caching;
using System.Text;

namespace CountriesFormApp
{
    public class CountryService
    {
        private const string BASE_URL = "https://raw.githubusercontent.com/stefangabos/world_countries/master/data";
        private MemoryCache cache = MemoryCache.Default;
        private string falgsDirectory = Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData), "CountryFlags");

        public string FalgsDirectory
        {
            get
            {
                return falgsDirectory;
            }
        }

        public List<Country> GetCountriesByLocale(string locale)
        {
            string cacheKey = $"countries_{locale}";

            if (cache.Contains(cacheKey))
            {
                return (List<Country>)cache.Get(cacheKey);
            }

            string countriesUrl = $"{BASE_URL}/countries/{locale}/countries.json";
            List<Country> countries = FetchData<Country>(countriesUrl);

            cache.Add(cacheKey, countries, DateTimeOffset.UtcNow.AddHours(1));

            return countries;
        }

        public List<Subdivision> GetSubdivisions()
        {
            string cacheKey = "subdivisions";

            if (cache.Contains(cacheKey))
            {
                return (List<Subdivision>)cache.Get(cacheKey);
            }

            string subdivisionUrl = $"{BASE_URL}/subdivisions/subdivisions.json";
            List<Subdivision> subdivisions = FetchData<Subdivision>(subdivisionUrl);

            cache.Add(cacheKey, subdivisions, DateTimeOffset.UtcNow.AddHours(1));

            return subdivisions;
        }

        public string GetCountryFlagPath(string countryalpha2Code)
        {
            string flagUrl = $"{BASE_URL}/flags/64x64/{countryalpha2Code}.png";
            string localFlagPath = Path.Combine(falgsDirectory, $"{countryalpha2Code}.png");

            if (!File.Exists(localFlagPath))
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(flagUrl, localFlagPath);
                }
            }

            return localFlagPath;
        }

        public Stream GetCountryFlag(string countryalpha2Code)
        {
            string flagUrl = $"{BASE_URL}/flags/64x64/{countryalpha2Code}.png";

            using (WebClient client = new WebClient())
            {
                Stream stream = client.OpenRead(flagUrl);

                return stream;
            }
        }

        private List<T> FetchData<T>(string url)
        {
            HttpWebRequest request = WebRequest.CreateHttp(url);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                string jsonResponse = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<T>>(jsonResponse);
            }
        }
    }
}
