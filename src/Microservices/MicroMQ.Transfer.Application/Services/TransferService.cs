using System.Collections.Generic;
using MicroMQ.Domain.Core.Bus;
using MicroMQ.Transfer.Application.Interfaces;
using MicroMQ.Transfer.Domain.Interfaces.Repositories;
using MicroMQ.Transfer.Domain.Models;

namespace MicroMQ.Transfer.Application.Services
{
    public class TransferService: ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus; 

        public TransferService(
            ITransferRepository transferRepository,
            IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}