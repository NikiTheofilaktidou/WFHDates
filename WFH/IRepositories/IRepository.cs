using WFH.Interfaces;
using WFH.Models;

namespace WFH.IRepositories
{
    public interface IRepository
    {
        IWFHDateRepository WFHDate { get; }
        IHolidayRepository Holiday { get; }
        IUserRepository User { get; }
        IPatternRepository Pattern { get; }
    }
}
