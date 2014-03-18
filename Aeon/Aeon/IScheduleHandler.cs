using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeon
{
    public interface IScheduleHandler
    {
        IScheduleStatus HandleCommand(IScheduleCommand command);
        Task<IScheduleStatus> HandleCommandAsync(IScheduleCommand command);
    }
}
