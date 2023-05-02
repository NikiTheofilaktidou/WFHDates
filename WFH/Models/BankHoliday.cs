using WFH.Enums;

namespace WFH.Models
{
    public class BankHoliday
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public CountryCode CountryCode { get; set; }
        public Country Country { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public int Period { get; set; }
    }
}
