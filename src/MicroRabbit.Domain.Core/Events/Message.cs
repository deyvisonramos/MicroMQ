﻿using MediatR;

namespace MicroMQ.Domain.Core.Events
{
    public abstract class Message: IRequest<bool>
    {
        protected Message()
        {
            Type = GetType().Name;
        }

        public string Type { get; protected set; }
    }
}