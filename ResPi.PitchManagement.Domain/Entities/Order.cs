using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResPi.PitchManagement.Domain.Common;

namespace ResPi.PitchManagement.Domain.Entities
{
    public class Order : AuditableEntity
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
        public bool OrderPaid { get; set; }
    }
}
