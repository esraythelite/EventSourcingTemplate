using EventSourcing.Domain.Interfaces.Action;
using EventSourcing.Domain.Interfaces.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing.Domain.Interfaces.Queue
{
    public interface IProducer
    {
        Task BuildAsync(IAction<IEvent, IActionInputDto<IEvent>, IActionOutputDto<IEvent>> action) ;
    }
}
