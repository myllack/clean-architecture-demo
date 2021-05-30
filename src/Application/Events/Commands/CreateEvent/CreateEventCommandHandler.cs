using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Events.Commands.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, int>
    {
        private readonly IEventCommands _eventCommands;

        public CreateEventCommandHandler(IEventCommands eventCommands)
        {
            _eventCommands = eventCommands;
        }

        public async Task<int> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var newEvent = new Event
            {
                Name = request.Name,
                Dates = request.Dates
            };

            return await _eventCommands.CreateEvent(newEvent);
        }
    }
}