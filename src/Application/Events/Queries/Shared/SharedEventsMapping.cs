using Application.Events.Queries.Shared;
using AutoMapper;
using Domain.Entities;

namespace Application.Events.Queries.GetEventDetails
{
    public class SharedEventsMapping : Profile
    {
        public SharedEventsMapping()
        {
            CreateMap<Vote, VoteViewModel>();
        }
    }
}