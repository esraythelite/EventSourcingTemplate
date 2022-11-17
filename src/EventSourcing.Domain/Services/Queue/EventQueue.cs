using EventSourcing.Domain.Interfaces.Event;
using EventSourcing.Domain.Interfaces.Queue;

namespace EventSourcing.Domain.Services.Queue
{
    public class EventQueue : IEventQueue
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Queue<IEvent> Events { get; set; } = new Queue<IEvent>();

        public void AddEvent( IEvent @event ) => Events.Enqueue(@event);
    }
}