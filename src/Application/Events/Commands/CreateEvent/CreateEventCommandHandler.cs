using Application.Interfaces;
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

        public Task<int> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}