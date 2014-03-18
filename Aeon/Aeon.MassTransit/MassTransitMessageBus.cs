using Aeon.MessageBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeon.MassTransit
{
    public class MassTransitMessageBus : IMessageBus
    {
        public void Publish(ICommandEvent commandEvent)
        {
            throw new NotImplementedException();
        }

        public void Subscribe<TEvent>() where TEvent : ICommandEvent
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe<TEvent>() where TEvent : ICommandEvent
        {
            throw new NotImplementedException();
        }

        public void AwaitReply<TReply>() where TReply : IHandlerReply
        {
            throw new NotImplementedException();
        }
    }
}
