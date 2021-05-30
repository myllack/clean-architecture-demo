using Application.Events.Queries.GetEvents;
using Application.Interfaces;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class EventQueries : IEventQueries
    {
        private readonly InMemoryEventStore _eventStore;
        private readonly IMapper _mapper;

        public EventQueries(InMemoryEventStore eventStore, IMapper mapper)
        {
            _eventStore = eventStore;
            _mapper = mapper;
        }

        public async Task<List<EventViewModel>> GetEvents()
        {
            var events = _eventStore.GetEvents();

            return _mapper.Map<List<EventViewModel>>(events);
        }
    }
}