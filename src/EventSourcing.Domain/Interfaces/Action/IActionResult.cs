using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Interfaces.Action
{
    public interface IActionResult : IEvent
    {
        Guid Id { get; set; }
        Task<bool> IsEligible( Guid compareId ) => Task.FromResult(Id == compareId);
    }
}