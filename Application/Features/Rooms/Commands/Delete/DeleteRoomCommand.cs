using Application.Features.Rooms.Commands.Delete;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Rooms.Commands.Delete;

public class DeleteRoomCommand : IRequest<DeletedRoomResponse>
{
    public Guid Id { get; set; }

    public class DeleteRoomCommandHandler : IRequestHandler<DeleteRoomCommand, DeletedRoomResponse>
    {
        private readonly IRoomRepository _RoomRepository;
        private readonly IMapper _mapper;

        public DeleteRoomCommandHandler(IRoomRepository RoomRepository, IMapper mapper)
        {
            _RoomRepository = RoomRepository;
            _mapper = mapper;
        }

        public async Task<DeletedRoomResponse>? Handle(DeleteRoomCommand request, CancellationToken cancellationToken)
        {
            Room? Room = await _RoomRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

            await _RoomRepository.DeleteAsync(Room);

            DeletedRoomResponse response = _mapper.Map<DeletedRoomResponse>(Room);

            return response;
        }
    }
}