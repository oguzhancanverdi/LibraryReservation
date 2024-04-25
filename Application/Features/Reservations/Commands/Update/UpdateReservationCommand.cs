using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reservations.Commands.Update;

public class UpdateReservationCommand : IRequest<UpdatedReservationResponse>
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid SeatId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public class UpdateReservationCommandHandler : IRequestHandler<UpdateReservationCommand, UpdatedReservationResponse>
    {
        private readonly IReservationRepository _ReservationRepository;
        private readonly IMapper _mapper;

        public UpdateReservationCommandHandler(IReservationRepository ReservationRepository, IMapper mapper)
        {
            _ReservationRepository = ReservationRepository;
            _mapper = mapper;
        }

        public async Task<UpdatedReservationResponse> Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
        {
            Reservation? Reservation = await _ReservationRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

            Reservation = _mapper.Map(request, Reservation);

            await _ReservationRepository.UpdateAsync(Reservation);

            UpdatedReservationResponse response = _mapper.Map<UpdatedReservationResponse>(Reservation);

            return response;
        }
    }
}
