using EventSourcing.Domain.Interfaces.Action;

namespace EventSourcing.Domain.Services.Action.SimpleRegister
{
    public class RegisterSuccessResultEvent<T> : IActionSuccessResult<T> where T : IActionOutputDto
    {
    
        public Guid Id { get; set; } = Guid.NewGuid();
        public T Result { get; set; }
        

    }
}