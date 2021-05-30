using AutoMapper;
using Domain.Entities;

namespace Application.Events.Queries.GetEvents
{
    public class GetEventsMapping : Profile
    {
        public GetEventsMapping()
        {
            CreateMap<Event, EventViewModel>();
        }
    }
}