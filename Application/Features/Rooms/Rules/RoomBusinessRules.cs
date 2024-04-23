using Application.Features.Rooms.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Rooms.Rules;

public class RoomBusinessRules : BaseBusinessRules
{
    private readonly IRoomRepository _RoomRepository;

    public RoomBusinessRules(IRoomRepository RoomRepository)
    {
        _RoomRepository = RoomRepository;
    }

    public async Task RoomNameCannotBeDuplicatedWhenInserted(string name)
    {
        Room? result = await _RoomRepository.GetAsync(predicate: b => b.Name.ToLower() == name.ToLower());

        if (result != null)
        {
            //throw new BusinessException(RoomsMessages.RoomNameExists);
            throw new Exception();
        }
    }
}
