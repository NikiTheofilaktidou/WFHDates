using WFH.Enums;

namespace WFH.Models
{
    public class WFHDate
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public WeekDay Numeric { get; set; }
        public DateTime Date { get; set; }
        public Pattern? Pattern { get; set; }
    }
}
