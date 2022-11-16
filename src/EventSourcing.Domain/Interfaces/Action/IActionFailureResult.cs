using EventSourcing.Domain.Exceptions;

namespace EventSourcing.Domain.Interfaces.Action
{
    public interface IActionFailureResult : IActionResult
    {
        BaseException Error { get; set; }
    }
}