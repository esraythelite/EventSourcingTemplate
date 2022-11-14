using EventSourcing.Domain.Interfaces.Event;
using EventSourcing.Domain.Interfaces.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing.Domain.Services.Queue
{
    public class BasicEventQueue : IEventQueue
    {
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Queue<IEvent> Events { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddEvent( IEvent @event )
        {
            Events.Enqueue( @event );   
        }
    }
}
