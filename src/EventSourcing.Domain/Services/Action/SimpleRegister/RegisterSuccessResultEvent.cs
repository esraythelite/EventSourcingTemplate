using EventSourcing.Domain.Interfaces.Action;

namespace EventSourcing.Domain.Services.Action.SimpleRegister
{
    public class RegisterSuccessResultEvent : IActionSuccessResult<IActionOutputDto<RegisterCommandEvent>>
    {
        public Guid Id { get; set; }
        public IActionOutputDto<RegisterCommandEvent> Result { get; set; }
    }
}