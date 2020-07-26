using System.Threading.Tasks;
using MicroMQ.Domain.Core.Commands;
using MicroMQ.Domain.Core.Events;

namespace MicroMQ.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;
        void Publish<T>(T @event) where T : Event;
        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }

}