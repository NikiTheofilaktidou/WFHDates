using WFH.Enums;

namespace WFH.Models
{
    public class Holiday
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public CountryCode CountryCode { get; set; }
        public Country Country { get; set; }
        public DateTime Date { get; set; }
        public int Period { get; set; }
    }
}
