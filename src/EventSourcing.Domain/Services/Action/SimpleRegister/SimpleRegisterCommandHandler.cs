using EventSourcing.Domain.Interfaces.Action;

namespace EventSourcing.Domain.Services.Action.SimpleRegister
{
    public class SimpleRegisterCommandHandler : IAction<RegisterCommandEvent, IActionInputDto<RegisterCommandEvent>, IActionOutputDto<RegisterCommandEvent>>
    {
        public Task<IActionResult> Action( RegisterCommandEvent @event )
        {
            throw new NotImplementedException();
        }

        public Task<IActionOutputDto<RegisterCommandEvent>> ExecuteAsync( IActionInputDto<RegisterCommandEvent> input, CancellationToken? cancellationToken = null )
        {
            throw new NotImplementedException();
        }
    }
}
