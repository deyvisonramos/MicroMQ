using System.Collections.Generic;
using MicroMQ.Transfer.Domain.Models;

namespace MicroMQ.Transfer.Domain.Interfaces.Repositories
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
        void Add(TransferLog transferLog);
    }
}