using EventSourcing.Domain.Interfaces.Action;
using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Services.Action.SimpleRegister
{
    public class RegisterInputDto : IActionInputDto<RegisterCommandEvent>, IActionInputDto<IEvent>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}