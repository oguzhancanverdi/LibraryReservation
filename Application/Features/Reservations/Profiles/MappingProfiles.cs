using Application.Features.Reservations.Commands.Create;
using Application.Features.Reservations.Commands.Delete;
using Application.Features.Reservations.Commands.Update;
using Application.Features.Reservations.Queries.GetById;
using Application.Features.Reservations.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reservations.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Reservation, CreateReservationCommand>().ReverseMap();
        CreateMap<Reservation, CreatedReservationResponse>().ReverseMap();

        CreateMap<Reservation, UpdateReservationCommand>().ReverseMap();
        CreateMap<Reservation, UpdatedReservationResponse>().ReverseMap();

        CreateMap<Reservation, DeleteReservationCommand>().ReverseMap();
        CreateMap<Reservation, DeletedReservationResponse>().ReverseMap();

        CreateMap<Reservation, GetListReservationListItemDto>().ReverseMap();
        CreateMap<Reservation, GetByIdReservationResponse>().ReverseMap();
        CreateMap<Reservation, GetListByUserIdReservationListItemDto>().ReverseMap();

        CreateMap<Paginate<Reservation>, GetListResponse<GetListReservationListItemDto>>().ReverseMap();
        CreateMap<Paginate<Reservation>, GetListResponse<GetListByUserIdReservationListItemDto>>().ReverseMap();
    }
}
