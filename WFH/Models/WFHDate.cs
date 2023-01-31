using WFH.Enums;

namespace WFH.Models
{
    public class WFHDate
    {
        public string? Name { get; set; }
        public WeekDay Numeric { get; set; }
        public DateTime Date { get; set; }

        public Pattern? MyProperty { get; set; }
    }
}
