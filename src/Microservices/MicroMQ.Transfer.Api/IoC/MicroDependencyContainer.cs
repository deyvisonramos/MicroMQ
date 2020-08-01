using MicroMQ.Domain.Core.Bus;
using MicroMQ.Transfer.Application.Interfaces;
using MicroMQ.Transfer.Application.Services;
using MicroMQ.Transfer.Data.Repository;
using MicroMQ.Transfer.Domain.EventHandlers;
using MicroMQ.Transfer.Domain.Events;
using MicroMQ.Transfer.Domain.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MicroMQ.Transfer.Api.IoC
{
    public class MicroDependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Services
            services.AddTransient<ITransferService, TransferService>();

            //Domain Events
            services.AddTransient<TransferEventHandler>();
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            //Repositories
            services.AddTransient<ITransferRepository, TransferRepository>();
        }
    }
}