using EventSourcing.Domain.Exceptions;
using EventSourcing.Domain.Interfaces.Action;
using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Services.Action.SimpleRegister
{
    public class RegisterFailureResultEvent : IActionFailureResult
    {
        public Guid Id { get; set; }

        public BaseException Error { get; set; }
    }
}