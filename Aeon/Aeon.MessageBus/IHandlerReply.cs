using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeon.MessageBus
{
    public interface IHandlerReply
    {
        IScheduleStatus Status { get; set; }
    }
}
