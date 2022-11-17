using EventSourcing.Domain.Exceptions;
using EventSourcing.Domain.Interfaces.Mediator;
using EventSourcing.Domain.Interfaces.Queue;
using EventSourcing.Domain.Services.Queue;

namespace EventSourcing.Tests.Mediator
{
    public class UnitTests
    {
        [Fact]
        public async Task Should_Return_True_For_Added_Event_Handler()
        {
            IEvent evt = new RegisterCommandEvent();
            var action = new SimpleRegisterCommandHandler();
            IMediator mediator = GetMediator();

            await mediator.AddHandlerAsync(action);

            Assert.True(await mediator.IsHandlerExistsAsync(evt));
        }

        private static Domain.Services.Mediator.Mediator GetMediator() => new Domain.Services.Mediator.Mediator(new EventQueue());

        [Fact]
        public async Task Should_Return_False_For_Not_Added_Event_Handler()
        {
            IMediator mediator = GetMediator();

            Assert.False(await mediator.IsHandlerExistsAsync<RegisterCommandEvent>());
        }

        [Fact]
        public async Task Should_Throw_EventHandlerNotFoundException_If_Event_Handler_Not_exists()
        {
            IMediator mediator = GetMediator();

            await Assert.ThrowsAsync<EventHandlerNotFoundException>(async()=>await mediator.RunAsync(new RegisterCommandEvent()));
        }

        
    }
}
