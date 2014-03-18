using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeon
{
    public interface IScheduleStatus
    {
        ISchedule Schedule { get; }
        string StatusMessage { get; }
    }
}
