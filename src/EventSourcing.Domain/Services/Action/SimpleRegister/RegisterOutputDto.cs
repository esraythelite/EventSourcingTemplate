using EventSourcing.Domain.Interfaces.Action;

namespace EventSourcing.Domain.Services.Action.SimpleRegister
{
    public class RegisterOutputDto : IActionOutputDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}