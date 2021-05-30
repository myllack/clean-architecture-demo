using Application.Events.Queries.GetEventDetails;
using Application.Events.Queries.GetEvents;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IEventQueries
    {
        public Task<EventDetailsViewModel> GetEventDetails(int id);

        public Task<List<EventViewModel>> GetEvents();
    }
}