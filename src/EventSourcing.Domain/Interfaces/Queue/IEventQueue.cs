using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Interfaces.Queue
{
    public interface IEventQueue
    {
        Guid Id { get; set; }
        Queue<IEvent> Events { get; set; }
        void AddEvent(IEvent @event);
    }
}