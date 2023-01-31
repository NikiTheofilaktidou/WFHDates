using WFH.Enums;

namespace WFH.Models
{
    public class Country
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public CountryCode CountryCode { get; set; }
    }
}
