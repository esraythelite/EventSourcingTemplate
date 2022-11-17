using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Interfaces.Action
{
    public interface IAction<Event,InputDto, OutputDto>
        where Event : IEvent
        where InputDto : IActionInputDto<Event>
        where OutputDto : IActionOutputDto<Event>
    {
        Task<OutputDto> ExecuteAsync( InputDto input, CancellationToken? cancellationToken = null );
    }
}