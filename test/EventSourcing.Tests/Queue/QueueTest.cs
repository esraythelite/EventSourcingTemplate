using EventSourcing.Domain.Interfaces.Action;
using EventSourcing.Domain.Interfaces.Mediator;
using EventSourcing.Domain.Services.Queue;
using Shouldly;
using MediatorClass = EventSourcing.Domain.Services.Mediator.Mediator;
namespace EventSourcing.Tests.Queue
{
    public class QueueTest
    {
        EventQueue GetQueue() => new();
        Tuple<MediatorClass,EventQueue> GetMediator() {
            var queue = GetQueue();
            var mediator = new MediatorClass(queue);
            return new Tuple<MediatorClass, EventQueue>(mediator, queue);
        }

        [Fact]
        public void Should_Add_Event_Into_Queue()
        {
            var queue = GetQueue();
            queue.AddEvent(new RegisterCommandEvent());
            queue.Events.ShouldNotBeEmpty();
            queue.Events.Count.ShouldBe(1);
        }

        [Fact]
        public async Task Should_Not_Return_Zero_If_Queue_Contains_An_Item()
        {
    
            var (mediator, queue) = GetMediator();
           
            var res = new RegisterSuccessResultEvent();

            queue.AddEvent(new RegisterCommandEvent
            {
                Id = Guid.NewGuid(),
                Input = new RegisterInputDto
                {
                    Age = 36,
                    FirstName = "Yashar",
                    LastName = "Aliabbasi",
                    Id = Guid.NewGuid()

                }

            }); 

            await mediator.AddHandlerAsync(new SimpleRegisterCommandHandler());

            RegisterCommandEvent @event = queue.Events.Dequeue() as RegisterCommandEvent ?? throw new Exception();

            await mediator.RunAsync(@event, @event.Input, res);
            queue.Events.ShouldNotBeEmpty();
            queue.Events.Any(m => m.GetType() == res.GetType()).ShouldBeTrue();
            ((RegisterOutputDto)(res.Result)).FirstName.ShouldBe("Yashar");
            ((RegisterOutputDto)(res.Result)).LastName.ShouldBe("Aliabbasi");
            ((RegisterOutputDto)(res.Result)).Age.ShouldBe(36);
            ((RegisterOutputDto)(res.Result)).Id.ShouldNotBe(Guid.Empty);
        }
    }
}