using WFH.Models;

namespace WFH.IRepositories
{
    public interface IRepository
    {
        Task<IEnumerable<WFHDate>> GetWFHDates(int userId);
        Task<WFHDate> AddWFHDates(int userId);
        Task<WFHDate> UpdateWFHDates(int userId);
        void DeleteWFHDates(int employeeId);
    }
}
