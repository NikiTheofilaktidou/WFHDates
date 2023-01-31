using WFH.Enums;

namespace WFH.Models
{
    public class Pattern //example MTF MWF
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public Dictionary<Frequency, Order>? Composition { get; set; }
    }

    public enum Order //First or Second Week that 50%WFH should be applied
    {
        First=1, 
        Second
    }
}
