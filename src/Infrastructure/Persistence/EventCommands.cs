using Application.Interfaces;
using Domain.Entities;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class EventCommands : IEventCommands
    {
        private readonly InMemoryEventStore _eventStore;

        public EventCommands(InMemoryEventStore eventStore)
        {
            _eventStore = eventStore;
        }

        public async Task<int> CreateEvent(Event newEvent)
        {
            return _eventStore.AddEvent(newEvent);
        }
    }
}