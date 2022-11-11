using EventSourcing.Domain.Interfaces.Action;

namespace EventSourcing.Domain.Services.Action.SimpleRegister
{
    public class RegisterSuccessResultEvent : IActionSuccessResult<RegisterCommandEvent>
    {
        public Guid Id { get; set; }
        public RegisterCommandEvent Result {get;set;}
    }
}