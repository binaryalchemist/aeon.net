using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeon
{
    public interface ISchedule
    {
        Guid Id { get; }
        IScheduleSettings Settings { get; }
        DateTime? LastRunDate { get; }
        IScheduleStatus LastStatus { get; }
        bool IsApplicableToDateTime(DateTime dateTime);
    }
}
