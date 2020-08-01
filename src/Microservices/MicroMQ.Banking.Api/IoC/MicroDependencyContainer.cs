using MediatR;
using MicroMQ.Baking.Application.Interfaces;
using MicroMQ.Baking.Application.Services;
using MicroMQ.Banking.Data.Repositories;
using MicroMQ.Banking.Domain.CommandHandlers;
using MicroMQ.Banking.Domain.Commands;
using MicroMQ.Banking.Domain.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MicroMQ.Banking.Api.IoC
{
    public class MicroDependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            //Services
            services.AddTransient<IAccountService, AccountService>();

            //Repositories
            services.AddTransient<IAccountRepository, AccountRepository>();
        }
    }
}