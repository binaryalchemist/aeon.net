using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeon.MessageBus
{
    public interface IMessageBus
    {
        void Publish(ICommandEvent commandEvent);
        void Subscribe<TEvent>() where TEvent : ICommandEvent;
        void Unsubscribe<TEvent>() where TEvent : ICommandEvent;
        void AwaitReply<TReply>() where TReply : IHandlerReply;
    }
}
