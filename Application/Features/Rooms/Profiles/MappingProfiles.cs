using Application.Features.Rooms.Commands.Create;
using Application.Features.Rooms.Commands.Delete;
using Application.Features.Rooms.Commands.Update;
using Application.Features.Rooms.Queries.GetById;
using Application.Features.Rooms.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Rooms.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Room, CreateRoomCommand>().ReverseMap();
        CreateMap<Room, CreatedRoomResponse>().ReverseMap();

        CreateMap<Room, UpdateRoomCommand>().ReverseMap();
        CreateMap<Room, UpdatedRoomResponse>().ReverseMap();

        CreateMap<Room, DeleteRoomCommand>().ReverseMap();
        CreateMap<Room, DeletedRoomResponse>().ReverseMap();

        CreateMap<Room, GetListRoomListItemDto>().ReverseMap();
        CreateMap<Room, GetByIdRoomResponse>().ReverseMap();

        CreateMap<Paginate<Room>, GetListResponse<GetListRoomListItemDto>>().ReverseMap();
    }
}
