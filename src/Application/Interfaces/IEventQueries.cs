using Application.Events.Queries.GetEvents;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IEventQueries
    {
        public Task<List<EventViewModel>> GetEvents();
    }
}