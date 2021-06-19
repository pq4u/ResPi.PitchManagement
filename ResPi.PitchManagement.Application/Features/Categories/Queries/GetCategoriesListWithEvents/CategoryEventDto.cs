﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResPi.PitchManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class CategoryEventDto
    {
        public Guid EventID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Artist { get; set; }
        public DateTime Date { get; set; }
        public Guid CategoryID { get; set; }
    }
}
