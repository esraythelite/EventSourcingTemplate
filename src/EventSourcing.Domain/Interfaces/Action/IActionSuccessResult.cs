namespace EventSourcing.Domain.Interfaces.Action
{
    public interface IActionSuccessResult<T> : IActionResult
    {
        T Result { get; set; }
    }
}