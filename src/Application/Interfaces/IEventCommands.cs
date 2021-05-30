using Domain.Entities;

namespace Application.Interfaces
{
    public interface IEventCommands
    {
        public int CreateEvent(Event @event);
    }
}