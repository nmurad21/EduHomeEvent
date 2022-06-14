using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduhomeEvent.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public DateTime dateTime { get; set; }
        public string Desc { get; set; }
    }
}
