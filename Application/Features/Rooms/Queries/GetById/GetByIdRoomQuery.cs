using Application.Features.Rooms.Queries.GetById;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Rooms.Queries.GetById;

public class GetByIdRoomQuery : IRequest<GetByIdRoomResponse>
{
    public Guid Id { get; set; }

    public class GetByIdRoomQueryHandler : IRequestHandler<GetByIdRoomQuery, GetByIdRoomResponse>
    {
        private readonly IMapper _mapper;
        private readonly IRoomRepository _RoomRepository;

        public GetByIdRoomQueryHandler(IMapper mapper, IRoomRepository RoomRepository)
        {
            _mapper = mapper;
            _RoomRepository = RoomRepository;
        }

        public async Task<GetByIdRoomResponse> Handle(GetByIdRoomQuery request, CancellationToken cancellationToken)
        {
            Room? Room = await _RoomRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken, withDeleted: true);

            GetByIdRoomResponse response = _mapper.Map<GetByIdRoomResponse>(Room);

            return response;
        }
    }
}
