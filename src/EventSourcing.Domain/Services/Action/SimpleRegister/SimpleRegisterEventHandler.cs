using EventSourcing.Domain.Interfaces.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing.Domain.Services.Action.SimpleRegister
{
    public class SimpleRegisterEventHandler : IEventHandler<RegisterCommandEvent>
    {
        public Task Handle( IEvent @event )
        {
            var id = @event.Id;

            return Task.CompletedTask;
        }
    }
}
