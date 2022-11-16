using EventSourcing.Domain.Interfaces.Action;

namespace EventSourcing.Domain.Services.Action.SimpleRegister
{
    public class RegisterSuccessResultEvent : IActionSuccessResult<IActionOutputDto<RegisterCommandEvent>>
    {
        public RegisterSuccessResultEvent(RegisterInputDto inputDto)
        {

            Result.Id = inputDto.Id;
            //Result.Age = inputDto.Age;
            //Result.FirstName = inputDto.FirstName;
            //Result.LastName = inputDto.LastName;
        }
        public Guid Id { get; set; } = Guid.NewGuid();
        public IActionOutputDto<RegisterCommandEvent> Result { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        // public RegisterOutputDto Result { get; set ; } = new();

    }
}