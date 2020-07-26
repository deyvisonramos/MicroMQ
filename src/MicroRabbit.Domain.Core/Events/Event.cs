using System;

namespace MicroMQ.Domain.Core.Events
{
    public abstract class Event
    {
        protected Event()
        {
            Timestamp = DateTime.UtcNow;
        }

        public DateTime Timestamp { get; protected set; }
    }
}