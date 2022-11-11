using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Interfaces.Action
{
    public interface IActionInputDto<T> where T : IEvent
    {
        Guid Id { get; set; }
    }
}