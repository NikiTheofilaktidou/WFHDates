using Newtonsoft.Json;
using System.Data;
using System.Data.Entity;
using WFH.Enums;

namespace WFH.Models
{
    public class Country
    {

        [JsonProperty(PropertyName = "countryId")]
        public int CountryId { get; set; }

        [JsonProperty(PropertyName = "countryName")]
        public string? CountryName { get; set; }

        [JsonProperty(PropertyName = "countryHolidays")]
        public DbSet<BankHoliday>? CountryHolidays { get; set; }

         [JsonProperty(PropertyName = "countryCdde")]
        public CountryCode CountryCdde { get; set; }

        public Country()
        {
        }

        public Country(DataRow row)
        {
            CountryId = (int)row["CountryID"];
            CountryName = row["CountryName"] != DBNull.Value ? row["CountryName"].ToString() : string.Empty;
           // CountryHolidays = row["CountryHolidays"] != DBNull.Value ? (DbSet<BankHoliday>?)row["CountryHolidays"] : null; // Gonna get this through the API
            CountryCdde = (CountryCode)row["Country"];
        }
    }
}
