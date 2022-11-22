using EventSourcing.Domain.Interfaces.Action;
using EventSourcing.Domain.Interfaces.Event;
using System.Diagnostics;

namespace EventSourcing.Domain.Services.Action.SimpleRegister
{
    public class SimpleRegisterCommandHandler : IAction<RegisterCommandEvent, RegisterInputDto, RegisterOutputDto>
    {
        public async Task<RegisterOutputDto> ExecuteAsync(RegisterInputDto input, CancellationToken? cancellationToken = null )
        {
            return new RegisterOutputDto
            {
                Age = input.Age+1,
                FirstName = input.FirstName,
                LastName = input.LastName,
                Id = Guid.NewGuid()
            };
        }
    }
}
