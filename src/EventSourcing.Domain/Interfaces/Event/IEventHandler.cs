namespace EventSourcing.Domain.Interfaces.Event
{
    public interface IEventHandler<E> where E: IEvent
    {
        Task Handle(IEvent @event);
    }
}
