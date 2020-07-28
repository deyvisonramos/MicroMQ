using System.Collections.Generic;
using MicroMQ.Baking.Application.Interfaces;
using MicroMQ.Banking.Domain.Interfaces.Repositories;
using MicroMQ.Banking.Domain.Models;

namespace MicroMQ.Baking.Application.Services
{
    public class AccountService: IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }
    }
}