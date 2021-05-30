using MediatR;

namespace Application.Events.Queries.GetEventDetails
{
    public class GetEventDetailsQuery : IRequest<EventDetailsViewModel>
    {
        public int Id { get; set; }

        public GetEventDetailsQuery(int id)
        {
            Id = id;
        }
    }
}