using Application.Features.Rooms.Commands.Update;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Rooms.Commands.Update;

public class UpdateRoomCommand : IRequest<UpdatedRoomResponse>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }

    public class UpdateRoomCommandHandler : IRequestHandler<UpdateRoomCommand, UpdatedRoomResponse>
    {
        private readonly IRoomRepository _RoomRepository;
        private readonly IMapper _mapper;

        public UpdateRoomCommandHandler(IRoomRepository RoomRepository, IMapper mapper)
        {
            _RoomRepository = RoomRepository;
            _mapper = mapper;
        }

        public async Task<UpdatedRoomResponse> Handle(UpdateRoomCommand request, CancellationToken cancellationToken)
        {
            Room? Room = await _RoomRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

            Room = _mapper.Map(request, Room);

            await _RoomRepository.UpdateAsync(Room);

            UpdatedRoomResponse response = _mapper.Map<UpdatedRoomResponse>(Room);

            return response;
        }
    }
}
