using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Interfaces.Action
{
    public interface IActionOutputDto<T> where T : IEvent
    {
        Guid Id { get; set; }
        T Result { get; }
    }
}