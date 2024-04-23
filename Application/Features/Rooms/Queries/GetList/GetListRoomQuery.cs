using Application.Features.Rooms.Queries.GetList;
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

namespace Application.Features.Rooms.Queries.GetList;

public class GetListRoomQuery : IRequest<GetListResponse<GetListRoomListItemDto>>
{
    public PageRequest PageRequest { get; set; }

    public class GetListRoomQueryHandler : IRequestHandler<GetListRoomQuery, GetListResponse<GetListRoomListItemDto>>
    {
        private readonly IRoomRepository _RoomRepository;
        private readonly IMapper _mapper;

        public GetListRoomQueryHandler(IRoomRepository RoomRepository, IMapper mapper)
        {
            _RoomRepository = RoomRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListRoomListItemDto>> Handle(GetListRoomQuery request, CancellationToken cancellationToken)
        {
            Paginate<Room> Rooms = await _RoomRepository.GetListAsync(
                  index: request.PageRequest.PageIndex,
                  size: request.PageRequest.PageSize,
                  cancellationToken: cancellationToken
                 );

            GetListResponse<GetListRoomListItemDto> response = _mapper.Map<GetListResponse<GetListRoomListItemDto>>(Rooms);
            return response;
        }
    }
}