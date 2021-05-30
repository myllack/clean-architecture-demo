using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Event
    {
        public List<DateTime> Dates { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}