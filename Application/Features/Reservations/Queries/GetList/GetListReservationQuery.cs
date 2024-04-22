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

public class GetListReservationQuery : IRequest<GetListResponse<GetListReservationListItemDto>>
{
    public PageRequest PageRequest { get; set; }

    public class GetListReservationQueryHandler : IRequestHandler<GetListReservationQuery, GetListResponse<GetListReservationListItemDto>>
    {
        private readonly IReservationRepository _ReservationRepository;
        private readonly IMapper _mapper;

        public GetListReservationQueryHandler(IReservationRepository ReservationRepository, IMapper mapper)
        {
            _ReservationRepository = ReservationRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListReservationListItemDto>> Handle(GetListReservationQuery request, CancellationToken cancellationToken)
        {
            Paginate<Reservation> Reservations = await _ReservationRepository.GetListAsync(
                  index: request.PageRequest.PageIndex,
                  size: request.PageRequest.PageSize,
                  cancellationToken: cancellationToken
                 );

            GetListResponse<GetListReservationListItemDto> response = _mapper.Map<GetListResponse<GetListReservationListItemDto>>(Reservations);
            return response;
        }
    }
}
