using EventSourcing.Domain.Interfaces.Event;
using EventSourcing.Domain.Interfaces.Queue;

namespace EventSourcing.Domain.Services.Queue
{
    public class BasicEventQueue : IEventQueue
    {
        public Guid Id { get; set; }
        public Queue<IEvent> Events { get; set; } = new Queue<IEvent>();

        public void AddEvent( IEvent @event ) => Events.Enqueue(@event);
    }
}