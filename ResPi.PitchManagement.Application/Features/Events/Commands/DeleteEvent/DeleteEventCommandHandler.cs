using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ResPi.PitchManagement.Application.Contracts.Persistence;
using ResPi.PitchManagement.Domain.Entities;

namespace ResPi.PitchManagement.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommandHandler : IRequestHandler<DeleteEventCommand>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;

        public DeleteEventCommandHandler(IMapper mapper, IAsyncRepository<Event> eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }

        public async Task<Unit> Handle(DeleteEventCommand request, CancellationToken cancellationToken)
        {
            var eventToDelete = await _eventRepository.GetByIdAsync(request.EventID);

            await _eventRepository.DeleteASync(eventToDelete);

            return Unit.Value;
        }
    }
}
