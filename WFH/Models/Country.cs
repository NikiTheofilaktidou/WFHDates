namespace WFH.Models;

public sealed class Country
{
    public string? Name { get; set; }
    public enum CountryCode { GR, FR, GB, IT, US, FI, CH, CZ, PO }

    public IEnumerable<Holiday>? TraditionalHolidays { get; set; }
}
