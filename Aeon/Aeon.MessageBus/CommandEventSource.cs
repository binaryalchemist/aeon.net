using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeon.MessageBus
{
    public class CommandEventSource : ICommandEventSource
    {
        private readonly IScheduleRepository _scheduleRepository;
        public CommandEventSource(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        public virtual ICommandEvent CreateRunCommandEvent(ISchedule schedule)
        {
            return new CommandEvent 
            { 
                Command = new ScheduleCommand 
                { 
                    Schedule = schedule, 
                    Type = ScheduleCommandType.Run 
                } 
            };
        }

        public IEnumerable<ICommandEvent> Runnable()
        {
            var runnableSchedules = _scheduleRepository.GetRunnableSchedules(DateTime.Now);
            return runnableSchedules.Select(schedule => CreateRunCommandEvent(schedule));
        }
    }
}
