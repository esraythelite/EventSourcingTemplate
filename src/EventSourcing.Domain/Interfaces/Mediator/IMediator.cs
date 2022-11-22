using EventSourcing.Domain.Interfaces.Action;
using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Interfaces.Mediator
{
    public interface IMediator
    {
        Task AddHandlerAsync<E, T, K>(params IAction<E, T, K>[] handlers) where E : IEvent where T : IActionInputDto where K : IActionOutputDto;
        Task RunAsync<E, T, K>(E @event, T? input, IActionSuccessResult<K>? onSuccess = null, IActionFailureResult? onFailure = null) where E : IEvent where T : IActionInputDto where K : IActionOutputDto;
        Task<bool> IsHandlerExistsAsync(IEvent evt );
        Task<bool> IsHandlerExistsAsync<E>() where E : IEvent;

    }
}