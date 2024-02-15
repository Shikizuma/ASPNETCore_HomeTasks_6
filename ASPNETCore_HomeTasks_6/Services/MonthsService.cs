using ASPNETCore_HomeTasks_6.Interfaces;

namespace ASPNETCore_HomeTasks_6.Services
{
    public class MonthsService : IListService
    {
        public List<string> GetList()
        {
            return new List<string> { "Січень", "Лютий", "Березень", "Квітень", "Травень", "Червень", "Липень", "Серпень", "Вересень", "Жовтень", "Листопад", "Грудень" };
        }
    }
}
