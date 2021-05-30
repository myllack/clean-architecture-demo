using Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Persistence
{
    public class InMemoryEventStore
    {
        private static readonly List<Event> _events = new();

        public int AddEvent(Event newEvent)
        {
            newEvent.Id = _events.Count == 0 ? 0 : _events.Max(e => e.Id) + 1;

            _events.Add(newEvent);

            return newEvent.Id;
        }

        public Event GetEvent(int Id)
        {
            return _events.FirstOrDefault(e => e.Id == Id);
        }

        public List<Event> GetEvents()
        {
            return _events;
        }
    }
}