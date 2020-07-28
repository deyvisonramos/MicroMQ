﻿using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MicroMQ.Banking.Domain.Commands;
using MicroMQ.Banking.Domain.Events;
using MicroMQ.Domain.Core.Bus;

namespace MicroMQ.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler :
        IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            _bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));
            return Task.FromResult(true);
        }
    }
}