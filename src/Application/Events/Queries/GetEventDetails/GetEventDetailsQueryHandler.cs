using Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Events.Queries.GetEventDetails
{
    public class GetEventDetailsQueryHandler : IRequestHandler<GetEventDetailsQuery, EventDetailsViewModel>
    {
        private readonly IEventQueries _eventQueries;

        public GetEventDetailsQueryHandler(IEventQueries eventQueries)
        {
            _eventQueries = eventQueries;
        }

        public async Task<EventDetailsViewModel> Handle(GetEventDetailsQuery request, CancellationToken cancellationToken)
        {
            return await _eventQueries.GetEventDetails(request.Id);
        }
    }
}