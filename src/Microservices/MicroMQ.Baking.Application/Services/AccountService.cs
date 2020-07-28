using System.Collections.Generic;
using MicroMQ.Baking.Application.Interfaces;
using MicroMQ.Baking.Application.Models;
using MicroMQ.Banking.Domain.Commands;
using MicroMQ.Banking.Domain.Interfaces.Repositories;
using MicroMQ.Banking.Domain.Models;
using MicroMQ.Domain.Core.Bus;

namespace MicroMQ.Baking.Application.Services
{
    public class AccountService: IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;

        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand =  new CreateTransferCommand(
                accountTransfer.FromAccount,
                accountTransfer.ToAccount,
                accountTransfer.Amount);

            _bus.SendCommand(createTransferCommand);
        }
    }
}