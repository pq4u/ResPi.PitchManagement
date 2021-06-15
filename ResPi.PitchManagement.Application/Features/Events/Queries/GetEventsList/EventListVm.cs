using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResPi.PitchManagement.Domain.Entities;

namespace ResPi.PitchManagement.Application.Features.Events
{
    public class EventListVm
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Category Category { get; set; }
    }
}
