using Domain.Entities;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IEventCommands
    {
        public Task<int> CreateEvent(Event @event);
    }
}