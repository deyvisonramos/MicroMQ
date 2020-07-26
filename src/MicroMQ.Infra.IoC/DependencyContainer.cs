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
        }
    }
} 