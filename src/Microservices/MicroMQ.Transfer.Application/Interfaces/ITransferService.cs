using System.Collections.Generic;
using MicroMQ.Transfer.Domain.Models;

namespace MicroMQ.Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}