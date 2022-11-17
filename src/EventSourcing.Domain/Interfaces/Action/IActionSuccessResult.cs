using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Interfaces.Action
{
    public interface IActionSuccessResult<T> : IActionResult where T:IActionOutputDto<IEvent>
    {
        T Result { get; set; }
     
    }
}