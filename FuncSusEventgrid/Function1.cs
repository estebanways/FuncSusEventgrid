// Default URL for triggering event grid function in the local environment.
// http://localhost:7071/runtime/webhooks/EventGrid?functionName={functionname}

using System;
using Azure.Messaging;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Azure.Messaging.EventGrid;

namespace FuncSusEventgrid
{
    public class Function1
    {
        private readonly ILogger<Function1> _logger;

        public Function1(ILogger<Function1> logger)
        {
            _logger = logger;
        }

        [Function(nameof(FuncSusEventgrid))]
        public void Run([EventGridTrigger] EventGridEvent cloudEvent)
        {
            _logger.LogInformation("Event type: {type}, Event subject: {subject}, Event Data: {data}", cloudEvent.EventType, cloudEvent.Subject,cloudEvent.Data);
        }
    }
}
