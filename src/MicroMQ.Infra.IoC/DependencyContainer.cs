using MediatR;
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
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(
                    sp.GetService<IMediator>(),
                    scopeFactory
                    );
            });
        }
    }
}