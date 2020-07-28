using System.Collections.Generic;
using MicroMQ.Baking.Application.Models;
using MicroMQ.Banking.Domain.Models;

namespace MicroMQ.Baking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}