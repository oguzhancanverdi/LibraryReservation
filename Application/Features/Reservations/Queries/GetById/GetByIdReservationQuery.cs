using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reservations.Queries.GetById;

public class GetByIdReservationQuery : IRequest<GetByIdReservationResponse>
{
    public Guid Id { get; set; }

    public class GetByIdReservationQueryHandler : IRequestHandler<GetByIdReservationQuery, GetByIdReservationResponse>
    {
        private readonly IMapper _mapper;
        private readonly IReservationRepository _ReservationRepository;

        public GetByIdReservationQueryHandler(IMapper mapper, IReservationRepository ReservationRepository)
        {
            _mapper = mapper;
            _ReservationRepository = ReservationRepository;
        }

        public async Task<GetByIdReservationResponse> Handle(GetByIdReservationQuery request, CancellationToken cancellationToken)
        {
            Reservation? Reservation = await _ReservationRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken, withDeleted: true);

            GetByIdReservationResponse response = _mapper.Map<GetByIdReservationResponse>(Reservation);

            return response;
        }
    }
}
