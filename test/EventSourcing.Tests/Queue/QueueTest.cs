using EventSourcing.Domain.Interfaces.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing.Tests.Queue
{
    public class QueueTest
    {
        [Fact]
        public async Task Should_Not_Return_Zero_If_Queue_Contains_An_Item()
        {
            IMediator mediator = new Domain.Services.Mediator.Mediator();
            mediator.RunAsync(new RegisterCommandEvent());
            Assert.False(await mediator.IsQueuempty());
        }
    }
}
