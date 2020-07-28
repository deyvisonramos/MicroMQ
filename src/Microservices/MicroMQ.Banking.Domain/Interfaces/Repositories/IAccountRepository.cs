using System.Collections.Generic;
using MicroMQ.Banking.Domain.Models;

namespace MicroMQ.Banking.Domain.Interfaces.Repositories
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}