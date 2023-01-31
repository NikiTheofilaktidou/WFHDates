namespace WFH.Models
{
    public class User
    {
        public string? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime HiringDate { get; set; }
        public Country?  Country { get; set; }
    }
}
