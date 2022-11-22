using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Interfaces.Action
{
    public interface IActionInputDto
    {
        Guid Id { get; set; }
    }
}