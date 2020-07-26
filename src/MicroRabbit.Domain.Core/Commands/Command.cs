using System;
using MicroMQ.Domain.Core.Events;

namespace MicroMQ.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        protected Command()
        {
            Timestamp = DateTime.UtcNow;
        }

        public DateTime Timestamp { get; protected set; }
    }
}