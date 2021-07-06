using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ResPi.PitchManagement.Application.Features.Events.Commands.UpdateEvent
{
    public class UpdateEventCommand : IRequest
    {
        public Guid EventID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Artist { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryID { get; set; }
    }
}
