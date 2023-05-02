using System.Collections.Generic;
using WFH.Enums;

namespace WFH.Models
{
    public class Pattern //example MTF MWF
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public DateTime[]? Week1 { get; set; }
        public DateTime[]? Week2 { get; set; }
        public DateTime[]? Week3 { get; set; }
        public DateTime[]? Week4 { get; set; }
    }

    public enum Order //Week No
    {
        First=1, 
        Second,
        Third,
        Fourth
    }
}
