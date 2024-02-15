using ASPNETCore_HomeTasks_6.Interfaces;

namespace ASPNETCore_HomeTasks_6.Services
{
    public class WeekDaysService : IListService
    {
        public List<string> GetList()
        {
            return new List<string> { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця", "Субота", "Неділя" };
        }
    }
}
