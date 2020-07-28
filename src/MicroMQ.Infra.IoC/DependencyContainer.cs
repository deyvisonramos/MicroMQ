using MediatR;
using MicroMQ.Baking.Application.Interfaces;
using MicroMQ.Baking.Application.Services;
using MicroMQ.Banking.Data.Repositories;
using MicroMQ.Banking.Domain.CommandHandlers;
using MicroMQ.Banking.Domain.Commands;
using MicroMQ.Banking.Domain.Interfaces.Repositories;
using MicroMQ.Domain.Core.Bus;
using MicroMQ.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroMQ.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Domain Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            //Services
            services.AddTransient<IAccountService, AccountService>();

            //Repositories
            services.AddTransient<IAccountRepository, AccountRepository>();
        }
    }
} 