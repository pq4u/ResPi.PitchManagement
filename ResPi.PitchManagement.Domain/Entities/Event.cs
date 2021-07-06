using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResPi.PitchManagement.Domain.Common;

namespace ResPi.PitchManagement.Domain.Entities
{
    public class Event : AuditableEntity
    {
        public Guid EventID { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryID { get; set; }
    }
}
