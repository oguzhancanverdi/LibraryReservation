using Application.Features.Reservations.Rules;
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
    public DateTime Time { get; set; }

    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand, CreatedReservationResponse>
    {
        private readonly IReservationRepository _ReservationRepository;
        private readonly IMapper _mapper;
        private readonly ReservationBusinessRules _ReservationBusinessRules;

        public CreateReservationCommandHandler(IReservationRepository ReservationRepository, IMapper mapper, ReservationBusinessRules ReservationBusinessRules)
        {
            _ReservationRepository = ReservationRepository;
            _mapper = mapper;
            _ReservationBusinessRules = ReservationBusinessRules;
        }

        public async Task<CreatedReservationResponse>? Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            await _ReservationBusinessRules.ReservationTimeCannotBeDuplicatedWhenInserted(request.Time);

            Reservation Reservation = _mapper.Map<Reservation>(request);
            Reservation.Id = Guid.NewGuid();

            var result = await _ReservationRepository.AddAsync(Reservation);

            CreatedReservationResponse createdReservationResponse = _mapper.Map<CreatedReservationResponse>(result);

            return createdReservationResponse;
        }
    }
}