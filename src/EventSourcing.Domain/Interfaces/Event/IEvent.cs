namespace EventSourcing.Domain.Interfaces.Event
{
    public interface IEvent
    {
        Guid Id { get; set; }
    }
}