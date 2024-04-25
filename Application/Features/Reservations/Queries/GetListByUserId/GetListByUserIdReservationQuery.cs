using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reservations.Queries.GetList;

public class GetListByUserIdReservationQuery : IRequest<GetListResponse<GetListByUserIdReservationListItemDto>>
{
    public PageRequest PageRequest { get; set; }
    public Guid UserId { get; set; }

    public class GetListByUserIdReservationQueryHandler : IRequestHandler<GetListByUserIdReservationQuery, GetListResponse<GetListByUserIdReservationListItemDto>>
    {
        private readonly IReservationRepository _ReservationRepository;
        private readonly IMapper _mapper;

        public GetListByUserIdReservationQueryHandler(IReservationRepository ReservationRepository, IMapper mapper)
        {
            _ReservationRepository = ReservationRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByUserIdReservationListItemDto>> Handle(GetListByUserIdReservationQuery request, CancellationToken cancellationToken)
        {
            Paginate<Reservation> Reservations = await _ReservationRepository.GetListAsync(
                predicate: r => r.UserId == request.UserId,
                  cancellationToken: cancellationToken
                 );

            GetListResponse<GetListByUserIdReservationListItemDto> response = _mapper.Map<GetListResponse<GetListByUserIdReservationListItemDto>>(Reservations);
            return response;
        }
    }
}
