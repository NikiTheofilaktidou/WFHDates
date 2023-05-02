using WFH.Interfaces;
using WFH.Models;

namespace WFH.IRepositories
{
    public interface IRepository
    {
        IWFHDateRepository WFHDate { get; }
        IBankHolidayRepository Holiday { get; }
        IUserRepository User { get; }
        IPatternRepository Pattern { get; }
    }
}
