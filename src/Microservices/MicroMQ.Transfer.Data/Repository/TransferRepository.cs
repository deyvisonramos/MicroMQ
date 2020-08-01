using System.Collections.Generic;
using MicroMQ.Transfer.Data.Context;
using MicroMQ.Transfer.Domain.Interfaces.Repositories;
using MicroMQ.Transfer.Domain.Models;

namespace MicroMQ.Transfer.Data.Repository
{
    public class TransferRepository: ITransferRepository
    {
        private readonly TransferDbContext _context;

        public TransferRepository(TransferDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _context.TranferLogs;
        }
    }
}