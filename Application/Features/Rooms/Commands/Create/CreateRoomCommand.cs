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

namespace Application.Features.Rooms.Commands.Create;

public class CreateRoomCommand : IRequest<CreatedRoomResponse>, ITransactionalRequest
{
    public string Name { get; set; }
    public int Capacity { get; set; }

    public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, CreatedRoomResponse>
    {
        private readonly IRoomRepository _RoomRepository;
        private readonly IMapper _mapper;
        private readonly RoomBusinessRules _RoomBusinessRules;

        public CreateRoomCommandHandler(IRoomRepository RoomRepository, IMapper mapper, RoomBusinessRules RoomBusinessRules)
        {
            _RoomRepository = RoomRepository;
            _mapper = mapper;
            _RoomBusinessRules = RoomBusinessRules;
        }

        public async Task<CreatedRoomResponse>? Handle(CreateRoomCommand request, CancellationToken cancellationToken)
        {
            await _RoomBusinessRules.RoomNameCannotBeDuplicatedWhenInserted(request.Name);

            Room Room = _mapper.Map<Room>(request);
            Room.Id = Guid.NewGuid();

            var result = await _RoomRepository.AddAsync(Room);

            CreatedRoomResponse createdRoomResponse = _mapper.Map<CreatedRoomResponse>(result);

            return createdRoomResponse;
        }
    }
}