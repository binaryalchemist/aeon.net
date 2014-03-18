using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aeon.MessageBus
{
    public class Scheduler
    {
        private readonly ICommandEventSource _commandEventSource;
        private readonly IMessageBus _messageBus;
        private readonly CancellationTokenSource _cancellationTokenSource;

        public Scheduler(IMessageBus messageBus, ICommandEventSource commandEventSource)
        {
            _commandEventSource = commandEventSource;
            _messageBus = messageBus;
            _cancellationTokenSource = new CancellationTokenSource();
        }

        public void Start()
        {
            Task.Factory.StartNew(() =>
               {
                   while (!_cancellationTokenSource.IsCancellationRequested)
                   {
                       var commandEvents = _commandEventSource.Runnable();

                       foreach (var commandEvent in commandEvents)
                       {
                           SendCommand(commandEvent);
                       }
                   }
                }, _cancellationTokenSource.Token);
        }

        public void Stop()
        {
            _cancellationTokenSource.Cancel();
        }

        public void SendCommand(ICommandEvent commandEvent)
        {
            _messageBus.Publish(commandEvent);
        }
    }
}
