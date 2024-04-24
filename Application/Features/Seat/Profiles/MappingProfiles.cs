using Application.Features.Seats.Commands.Create;
using Application.Features.Seats.Commands.Delete;
using Application.Features.Seats.Commands.Update;
using Application.Features.Seats.Queries.GetById;
using Application.Features.Seats.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Seats.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Seat, CreateSeatCommand>().ReverseMap();
        CreateMap<Seat, CreatedSeatResponse>().ReverseMap();

        CreateMap<Seat, UpdateSeatCommand>().ReverseMap();
        CreateMap<Seat, UpdatedSeatResponse>().ReverseMap();

        CreateMap<Seat, DeleteSeatCommand>().ReverseMap();
        CreateMap<Seat, DeletedSeatResponse>().ReverseMap();

        CreateMap<Seat, GetListSeatListItemDto>().ReverseMap();
        CreateMap<Seat, GetByIdSeatResponse>().ReverseMap();

        CreateMap<Paginate<Seat>, GetListResponse<GetListSeatListItemDto>>().ReverseMap();
    }
}
