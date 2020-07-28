using System.Collections.Generic;
using System.Threading.Tasks;
using MicroMQ.Banking.Data.Context;
using MicroMQ.Banking.Domain.Interfaces.Repositories;
using MicroMQ.Banking.Domain.Models;

namespace MicroMQ.Banking.Data.Repositories
{
    public sealed class AccountRepository: IAccountRepository
    {
        private readonly BankingDbContext _context;

        public AccountRepository(BankingDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _context.Accounts;
        }
    }
}