using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reservations.Commands.Delete;

public class DeleteReservationCommand : IRequest<DeletedReservationResponse>
{
    public Guid Id { get; set; }

    public class DeleteReservationCommandHandler : IRequestHandler<DeleteReservationCommand, DeletedReservationResponse>
    {
        private readonly IReservationRepository _ReservationRepository;
        private readonly IMapper _mapper;

        public DeleteReservationCommandHandler(IReservationRepository ReservationRepository, IMapper mapper)
        {
            _ReservationRepository = ReservationRepository;
            _mapper = mapper;
        }

        public async Task<DeletedReservationResponse>? Handle(DeleteReservationCommand request, CancellationToken cancellationToken)
        {
            Reservation? Reservation = await _ReservationRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

            await _ReservationRepository.DeleteAsync(Reservation);

            DeletedReservationResponse response = _mapper.Map<DeletedReservationResponse>(Reservation);

            return response;
        }
    }
}
