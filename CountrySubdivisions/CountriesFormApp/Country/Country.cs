using System;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesFormApp
{
    public class Country
    {
        public int Id { get; set; }
        public string Alpha2 { get; set; }
        public string Alpha3 { get; set; }
        public string Name { get; set; }
    }

    public class Subdivision
    {
        public string Country { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
