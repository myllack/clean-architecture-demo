using Application.Events.Queries.Shared;
using System;
using System.Collections.Generic;

namespace Application.Events.Queries.GetEventDetails
{
    public class EventDetailsViewModel
    {
        public List<DateTime> Dates { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<VoteViewModel> Votes { get; set; }
    }
}