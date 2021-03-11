﻿using MediatR;
using Microsoft.Extensions.Logging;
using OrderingService.Infrastructure.Idempotency;

namespace OrderingService.Application.Commands
{
    // Use for Idempotency in Command process

    public class CreateOrderIdentifiedCommandHandler : IdentifiedCommandHandler<CreateOrderCommand, bool>
    {
        public CreateOrderIdentifiedCommandHandler(IMediator mediator, IRequestManager requestManager, ILoggerFactory loggerFactory)
            : base(mediator, requestManager, loggerFactory)
        {
        }

        protected override bool CreateResultForDuplicateRequest()
        {
            return true;                // Ignore duplicate requests for creating order.
        }
    }
}