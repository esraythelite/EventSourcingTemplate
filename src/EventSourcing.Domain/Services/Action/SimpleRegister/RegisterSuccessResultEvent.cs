using EventSourcing.Domain.Interfaces.Action;
using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Services.Action.SimpleRegister
{
    public class RegisterSuccessResultEvent : IActionSuccessResult<IActionOutputDto<RegisterCommandEvent>>
    {

        public Guid Id { get; set; } = Guid.NewGuid();
        public IActionOutputDto<RegisterCommandEvent>  Result { get; set; }

    }
}