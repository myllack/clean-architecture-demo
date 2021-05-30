using System;
using System.Collections.Generic;

namespace Application.Events.Queries.Shared
{
    public class VoteViewModel
    {
        public DateTime Date { get; set; }

        public List<string> People { get; set; }
    }
}