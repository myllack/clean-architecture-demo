using MediatR;
using System;
using System.Collections.Generic;

namespace Application.Events.Commands.CreateEvent
{
    public class CreateEventCommand : IRequest<int>
    {
        public List<DateTime> Dates { get; set; }
        public string Name { get; set; }
    }
}