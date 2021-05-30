using Application.Events.Queries.GetEvents;
using Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class EventQueries : IEventQueries
    {
        public async Task<List<EventViewModel>> GetEvents()
        {
            return new List<EventViewModel>
            {
                new EventViewModel
                {
                    Id = 0,
                    Name = "test1"
                },
                new EventViewModel
                {
                    Id = 1,
                    Name = "test2"
                },
            };
        }
    }
}