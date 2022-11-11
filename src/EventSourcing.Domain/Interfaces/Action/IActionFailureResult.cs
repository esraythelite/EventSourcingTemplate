using EventSourcing.Domain.Exceptions;

namespace EventSourcing.Domain.Interfaces.Action
{
    public interface IActionFailureResult
    {
        BaseException Error { get; }
    }
}