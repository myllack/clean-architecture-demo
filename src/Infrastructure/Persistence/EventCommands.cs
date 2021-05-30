using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Persistence
{
    public class EventCommands : IEventCommands
    {
        public int CreateEvent(Event @event)
        {
            throw new System.NotImplementedException();
        }
    }
}