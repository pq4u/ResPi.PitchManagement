using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResPi.PitchManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class CategoryEventListVm
    {
        public Guid CategoryID { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryEventDto> Events { get; set; }
        
    }
}
