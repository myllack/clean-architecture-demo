using AutoMapper;
using Domain.Entities;

namespace Application.Events.Queries.GetEventDetails
{
    public class GetEventDetailsQueryMapping : Profile
    {
        public GetEventDetailsQueryMapping()
        {
            CreateMap<Event, EventDetailsViewModel>();
        }
    }
}