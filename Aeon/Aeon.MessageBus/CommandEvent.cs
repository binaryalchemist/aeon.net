using Aeon.MessageBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeon.MessageBus
{
    public class CommandEvent : ICommandEvent
    {
        public IScheduleCommand Command { get; set; }
    }
}
