using Application.Features.Tables.Commands.Create;
using Application.Features.Tables.Commands.Delete;
using Application.Features.Tables.Commands.Update;
using Application.Features.Tables.Queries.GetById;
using Application.Features.Tables.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tables.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Table, CreateTableCommand>().ReverseMap();
        CreateMap<Table, CreatedTableResponse>().ReverseMap();

        CreateMap<Table, UpdateTableCommand>().ReverseMap();
        CreateMap<Table, UpdatedTableResponse>().ReverseMap();

        CreateMap<Table, DeleteTableCommand>().ReverseMap();
        CreateMap<Table, DeletedTableResponse>().ReverseMap();

        CreateMap<Table, GetListTableListItemDto>().ReverseMap();
        CreateMap<Table, GetByIdTableResponse>().ReverseMap();

        CreateMap<Paginate<Table>, GetListResponse<GetListTableListItemDto>>().ReverseMap();
    }
}
