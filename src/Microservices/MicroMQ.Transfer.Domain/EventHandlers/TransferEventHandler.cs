using System;
using System.Threading.Tasks;
using MicroMQ.Domain.Core.Bus;
using MicroMQ.Transfer.Domain.Events;
using Newtonsoft.Json;

namespace MicroMQ.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler: IEventHandler<TransferCreatedEvent>
    {
        public Task Handle(TransferCreatedEvent @event)
        {
            Console.WriteLine($"received message: {JsonConvert.SerializeObject(@event)}");
            return Task.CompletedTask;
        }
    }
}