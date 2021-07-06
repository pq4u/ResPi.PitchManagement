using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ResPi.PitchManagement.Application.Features.Categories.Queries.GetCategoriesList;
using ResPi.PitchManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using ResPi.PitchManagement.Application.Features.Events;
using ResPi.PitchManagement.Application.Features.Events.Commands.CreateEvent;
using ResPi.PitchManagement.Application.Features.Events.Commands.UpdateEvent;
using ResPi.PitchManagement.Domain.Entities;

namespace ResPi.PitchManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
        }
    }
}
