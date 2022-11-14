using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSourcing.Domain.Interfaces.Queue
{
    public interface IConsumer
    {
        void StartConsuming(CancellationToken cancellationToken);
    }
}
