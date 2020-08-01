using System;
using System.Threading.Tasks;
using MicroMQ.Domain.Core.Bus;
using MicroMQ.Transfer.Domain.Events;
using MicroMQ.Transfer.Domain.Interfaces.Repositories;
using MicroMQ.Transfer.Domain.Models;

namespace MicroMQ.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler: IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;

        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.Add(new TransferLog
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmount = @event.Amount
            });
            Console.WriteLine("saved transfer log");
            return Task.CompletedTask;
        }
    }
}