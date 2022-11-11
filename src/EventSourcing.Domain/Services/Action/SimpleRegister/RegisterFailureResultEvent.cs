using EventSourcing.Domain.Exceptions;
using EventSourcing.Domain.Interfaces.Action;

namespace EventSourcing.Domain.Services.Action.SimpleRegister
{
    public class RegisterFailureResultEvent : IActionFailureResult
    {
        public Guid Id { get; set; }

        public BaseException Error { get; set; }
    }
}