using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Services.Action.SimpleRegister
{
    public class RegisterCommandEvent : IEvent
    {
        public Guid Id { get; set; }
        public RegisterInputDto Input { get; set; } 

    }
}