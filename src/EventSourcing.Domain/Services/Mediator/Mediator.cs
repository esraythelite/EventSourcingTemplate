﻿using EventSourcing.Domain.Exceptions;
using EventSourcing.Domain.Interfaces.Action;
using EventSourcing.Domain.Interfaces.Event;
using EventSourcing.Domain.Interfaces.Mediator;
using EventSourcing.Domain.Interfaces.Queue;
using EventSourcing.Domain.Services.Action.SimpleRegister;
using EventSourcing.Domain.Services.Queue;

namespace EventSourcing.Domain.Services.Mediator
{
    public class Mediator : IMediator
    {
        Dictionary<Type, List<object>> Handlers { get; set; } = new Dictionary<Type, List<object>>();
        IEventQueue EventQueue { get; set; }

        public Mediator( IEventQueue eventQueue )
        {
            EventQueue = eventQueue;
        }

        public async Task AddHandlerAsync<E>( params IActionHandler<E, IActionInputDto<E>, IActionOutputDto<E>>[] handlers ) where E : IEvent
        {
            if (!await IsHandlerExistsAsync<E>())
                Handlers[typeof(E)] = new List<object>();
            Handlers[typeof(E)].AddRange(handlers);
        }

        public Task<bool> IsHandlerExistsAsync( IEvent evt ) => Task.FromResult(Handlers.ContainsKey(evt.GetType()));
        public Task<bool> IsHandlerExistsAsync<E>() where E : IEvent
            => Task.FromResult(Handlers.ContainsKey(typeof(E)));

        public async Task RunAsync<E>( E @event, IActionInputDto<E>? input = null, IActionSuccessResult<IActionOutputDto<E>,E>? onSuccess = null, IActionFailureResult? onFailure = null ) where E : IEvent
        {
            if (!await IsHandlerExistsAsync<E>())
                throw new EventHandlerNotFoundException();

            var handlers = Handlers[typeof(E)];

            foreach (var handler in handlers)
            {
                try
                {
                    var h = handler as IActionHandler<E,            IActionInputDto<E>, IActionOutputDto<E>>;
                    var res = await h.ExecuteAsync(input);
                    if (onSuccess != null)
                    {
                        onSuccess.Result = res;
                        EventQueue.AddEvent(onSuccess);
                    }
                }
                catch (BaseException baseExp)
                {
                    if (onFailure != null)
                    {
                        onFailure.Error = baseExp;
                        EventQueue.AddEvent(onFailure);
                    }
                }
            }
        }

    }
}
