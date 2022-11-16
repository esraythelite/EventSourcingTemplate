namespace EventSourcing.Domain.Interfaces.Action
{
    public interface IActionSuccessResult<IActionOutputDto> : IActionResult 
    {
        IActionOutputDto Result { get; set; }
     
    }
}