using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeon
{
    public interface IScheduleRepository
    {
        ISchedule Create(IScheduleSettings scheduleSettings);
        ISchedule Get(Guid scheduleId);
        ISchedule Update(ISchedule schedule);
        IEnumerable<ISchedule> GetAllSchedules();
        IEnumerable<ISchedule> GetRunnableSchedules(DateTime dateTime);
        void Delete(Guid scheduleId);
    }
}
