using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Interfaces.Action
{
    public interface IActionOutputDto
    {
        Guid Id { get; set; }
    }
}