using EventSourcing.Domain.Interfaces.Action;
using System.Diagnostics;

namespace EventSourcing.Domain.Services.Action.SimpleRegister
{
    public class SimpleRegisterCommandHandler : IAction<RegisterCommandEvent, IActionInputDto<RegisterCommandEvent>, IActionOutputDto<RegisterCommandEvent>>
    {
        public async Task<IActionOutputDto<RegisterCommandEvent>> ExecuteAsync( IActionInputDto<RegisterCommandEvent> input, CancellationToken? cancellationToken = null )
        {
            var i = input as RegisterInputDto;
            return new RegisterOutputDto
            {
                Age = i.Age,
                FirstName = i.FirstName,
                LastName = i.LastName,
                Id = Guid.NewGuid()
            };
        }
    }
}
