using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Interfaces.Action
{
    public interface IAction<Event,InputDto, OutputDto
        //,SuccessEvent,FailureEvent
        >
        where Event : IEvent
        where InputDto : IActionInputDto<Event>
        where OutputDto : IActionOutputDto<Event>
        //where SuccessEvent : IActionSuccessResult<OutputDto>
    {
        Task<OutputDto> ExecuteAsync( InputDto input, CancellationToken? cancellationToken = null );
        Task<IActionResult> Action( Event @event);
    }
}