namespace EventSourcing.Domain.Interfaces.Action
{
    public interface IActionSuccessResult<T> : IActionResult where T : IActionOutputDto
    {
        T Result { get; set; }
    }
}