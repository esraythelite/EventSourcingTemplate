using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing.Domain.Interfaces.Event
{
    public interface IEventHandler<E> where E: IEvent
    {
        Task Handle(IEvent @event);
    }
}
