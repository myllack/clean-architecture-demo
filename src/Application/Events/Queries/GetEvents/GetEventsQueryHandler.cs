using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Events.Queries.GetEvents
{
    public class GetEventsQueryHandler : IRequestHandler<GetEventsQuery, List<EventViewModel>>
    {
        public async Task<List<EventViewModel>> Handle(GetEventsQuery request, CancellationToken cancellationToken)
        {
            return new List<EventViewModel>
            {
                new EventViewModel
                {
                    Id = 0,
                    Name = "test1"
                },
                new EventViewModel
                {
                    Id = 1,
                    Name = "test2"
                },
            };
        }
    }
}