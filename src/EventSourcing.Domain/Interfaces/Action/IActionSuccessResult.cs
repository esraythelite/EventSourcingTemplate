using EventSourcing.Domain.Interfaces.Event;

namespace EventSourcing.Domain.Interfaces.Action
{
    public interface IActionSuccessResult<T,E> : IActionResult where T: IActionOutputDto<E> where E : IEvent
    {
        T Result { get; set; }  
    }
}