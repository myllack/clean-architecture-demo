using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Vote
    {
        public DateTime Date { get; set; }

        public List<string> People { get; set; }
    }
}