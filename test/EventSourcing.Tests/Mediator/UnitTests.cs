using EventSourcing.Domain.Exceptions;
using EventSourcing.Domain.Interfaces.Mediator;
using EventSourcing.Domain.Interfaces.Queue;

namespace EventSourcing.Tests.Mediator
{
    public class UnitTests
    {
        [Fact]
        public async Task Should_Return_True_For_Added_Event_Handler()
        {
            IEvent evt = new RegisterCommandEvent();
            var action = new SimpleRegisterCommandHandler();
            IMediator mediator = new Domain.Services.Mediator.Mediator();

            await mediator.AddHandlerAsync(action);

            Assert.True(await mediator.IsHandlerExistsAsync(evt));
        }

        [Fact]
        public async Task Should_Return_False_For_Not_Added_Event_Handler()
        {
            IMediator mediator = new Domain.Services.Mediator.Mediator();

            Assert.False(await mediator.IsHandlerExistsAsync<RegisterCommandEvent>());
        }

        [Fact]
        public async Task Should_Throw_EventHandlerNotFoundException_If_Event_Handler_Not_exists()
        {
            IMediator mediator = new Domain.Services.Mediator.Mediator();

            await Assert.ThrowsAsync<EventHandlerNotFoundException>(async()=>await mediator.RunAsync(new RegisterCommandEvent()));
        }

        
    }
}
