using EventSourcing.Domain.Interfaces.Action;
using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Interfaces.Mediator
{
    public interface IMediator
    {
        Task AddHandlerAsync<E>(params IAction<E, IActionInputDto<E>, IActionOutputDto<E>>[] handlers ) where E : IEvent;
        Task RunAsync<E>( E @event, IActionInputDto<E>? input = null, IActionSuccessResult<IActionOutputDto<E>>? onSuccess = null, IActionFailureResult? onFailure = null ) where E : IEvent;
        Task<bool> IsHandlerExistsAsync( IEvent evt );
        Task<bool> IsHandlerExistsAsync<E>() where E : IEvent;
    }
}