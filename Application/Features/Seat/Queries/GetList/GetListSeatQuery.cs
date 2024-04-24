using Application.Features.Seats.Queries.GetList;
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

namespace Application.Features.Seats.Queries.GetList;

public class GetListSeatQuery : IRequest<GetListResponse<GetListSeatListItemDto>>
{
    public PageRequest PageRequest { get; set; }

    public class GetListSeatQueryHandler : IRequestHandler<GetListSeatQuery, GetListResponse<GetListSeatListItemDto>>
    {
        private readonly ISeatRepository _SeatRepository;
        private readonly IMapper _mapper;

        public GetListSeatQueryHandler(ISeatRepository SeatRepository, IMapper mapper)
        {
            _SeatRepository = SeatRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListSeatListItemDto>> Handle(GetListSeatQuery request, CancellationToken cancellationToken)
        {
            Paginate<Seat> Seats = await _SeatRepository.GetListAsync(
                  index: request.PageRequest.PageIndex,
                  size: request.PageRequest.PageSize,
                  cancellationToken: cancellationToken
                 );

            GetListResponse<GetListSeatListItemDto> response = _mapper.Map<GetListResponse<GetListSeatListItemDto>>(Seats);
            return response;
        }
    }
}