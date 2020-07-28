using System.Collections.Generic;
using MicroMQ.Banking.Domain.Models;

namespace MicroMQ.Baking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
    }
}