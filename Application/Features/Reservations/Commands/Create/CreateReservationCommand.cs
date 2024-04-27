using Application.Features.Reservations.Rules;
using Application.Features.Rooms.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Transaction;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reservations.Commands.Create;

public class CreateReservationCommand : IRequest<CreatedReservationResponse>, ITransactionalRequest
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Guid UserId { get; set; }
    public Guid SeatId { get; set; }

    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, CreatedReservationResponse>
    {
        private readonly IReservationRepository _ReservationRepository;
        private readonly ISeatRepository _SeatRepository;
        private readonly IMapper _mapper;
        private readonly ReservationBusinessRules _ReservationBusinessRules;
        private readonly ReservationHoursRules _ReservationHoursRules;

        public CreateReservationCommandHandler(IReservationRepository ReservationRepository, ISeatRepository SeatRepository, IMapper mapper, ReservationBusinessRules ReservationBusinessRules, ReservationHoursRules ReservationHoursRules)
        {
            _ReservationRepository = ReservationRepository;
            _SeatRepository = SeatRepository;
            _mapper = mapper;
            _ReservationBusinessRules = ReservationBusinessRules;
            _ReservationHoursRules = ReservationHoursRules;
        }

        public async Task<CreatedReservationResponse>? Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            await _ReservationHoursRules.ReservationLibraryClosedWhenInserted();
            await _ReservationBusinessRules.ReservationUserCheckWhenInserted(request.UserId);

            Reservation Reservation = _mapper.Map<Reservation>(request);
            Reservation.Id = Guid.NewGuid();
            Reservation.StartTime = DateTime.Now;
            Reservation.EndTime = DateTime.Now.AddHours(3);

            var result = await _ReservationRepository.AddAsync(Reservation);

            Seat seat = _SeatRepository.GetAsync(predicate: s => s.Id == Reservation.SeatId).Result;
            if (seat != null)
            {
                seat.IsReserved = true;
                await _SeatRepository.UpdateAsync(seat);
            }

            CreatedReservationResponse createdReservationResponse = _mapper.Map<CreatedReservationResponse>(result);

            return createdReservationResponse;
        }
    }
}