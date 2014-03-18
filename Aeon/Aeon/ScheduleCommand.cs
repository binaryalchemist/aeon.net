using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeon
{
    public class ScheduleCommand : IScheduleCommand
    {
        public ScheduleCommandType Type { get; set; }
        public ISchedule Schedule { get; set; }
    }
}
