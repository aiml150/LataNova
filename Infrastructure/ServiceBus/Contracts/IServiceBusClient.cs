﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.ServiceBus.Contracts
{
    public interface IServiceBusClient
    {
        Task PublishMessageToTopic<T>(T message, Dictionary<string, object> properties = null);
        Task ReceiveMessageFromQueue<T>(Func<T, ServiceBusClient.MessageProcessResponse> onProcess);
        Task ReceiveMessageFromTopic<T>(Func<T, ServiceBusClient.MessageProcessResponse> onProcess);
        Task SendMessageToQueue<T>(T message, Dictionary<string, object> properties = null);
    }
}
