﻿using EventSourcing.Domain.Exceptions;
using EventSourcing.Domain.Interfaces.Action;
using EventSourcing.Domain.Interfaces.Event;
using EventSourcing.Domain.Interfaces.Mediator;

namespace EventSourcing.Domain.Services.Mediator
{
    public class Mediator :IMediator
    {
        Dictionary<Type, List<object>> Handlers { get; set; } = new Dictionary<Type, List<object>>();
        public async Task AddHandlerAsync<E>(params IAction<E, IActionInputDto<E>, IActionOutputDto<E>>[] handlers ) where E : IEvent
        {
            if (!await IsHandlerExistsAsync<E>())
                Handlers[typeof(E)] = new List<object>();
            Handlers[typeof(E)].AddRange(handlers);
        }

        public Task<bool> IsHandlerExistsAsync( IEvent evt ) => Task.FromResult(Handlers.ContainsKey(evt.GetType()));
        public Task<bool> IsHandlerExistsAsync<E>() where E : IEvent
            => Task.FromResult(Handlers.ContainsKey(typeof(E)));

        public async Task RunAsync<E>( E @event, IActionInputDto<E>? input, IActionSuccessResult<IActionOutputDto<E>>? onSuccess = null, IActionFailureResult? onFailure = null ) where E : IEvent
        {
            if (!await IsHandlerExistsAsync<E>())
                throw new EventHandlerNotFoundException();

            var handlers = Handlers[typeof(E)];
            foreach (var handler in handlers)
            {
                try
                {
                    var res = await (handler as IAction<E, IActionInputDto<E>, IActionOutputDto<E>>).ExecuteAsync(input);
                    if (onSuccess != null)
                    {
                        onSuccess.Result = res;
                        //Add to queue
                        
                    }
                } catch (BaseException baseExp)
                {
                    
                }
            }
        }
    }
}
