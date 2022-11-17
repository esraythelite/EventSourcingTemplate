using EventSourcing.Domain.Interfaces.Action;
using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Services.Action.SimpleRegister
{
    public class RegisterOutputDto : IActionOutputDto<RegisterCommandEvent>
    {
 
        public Guid Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public RegisterCommandEvent Result => throw new NotImplementedException();

        //public RegisterCommandEvent Result => new()
        //{
        //    Id = Id,
        //    Input = new RegisterInputDto
        //    {
        //        Age = Age,
        //        FirstName = FirstName,
        //        Id = Id,
        //        LastName = LastName
        //    }
        //};


    }
}