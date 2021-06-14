using System;
using ResPi.PitchManagement.Domain.Entities;

namespace ResPi.PitchManagement.Application.Features.Events
{
    public class EventDetailVm
    {
        public Guid EventID { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public Guid CategoryID { get; set; }
        public CategoryDto Category { get; set; }
    }
}