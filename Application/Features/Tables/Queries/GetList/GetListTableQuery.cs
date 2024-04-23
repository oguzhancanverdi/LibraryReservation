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

namespace Application.Features.Tables.Queries.GetList;

public class GetListTableQuery : IRequest<GetListResponse<GetListTableListItemDto>>
{
    public PageRequest PageRequest { get; set; }

    public class GetListTableQueryHandler : IRequestHandler<GetListTableQuery, GetListResponse<GetListTableListItemDto>>
    {
        private readonly ITableRepository _TableRepository;
        private readonly IMapper _mapper;

        public GetListTableQueryHandler(ITableRepository TableRepository, IMapper mapper)
        {
            _TableRepository = TableRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListTableListItemDto>> Handle(GetListTableQuery request, CancellationToken cancellationToken)
        {
            Paginate<Table> Tables = await _TableRepository.GetListAsync(
                  index: request.PageRequest.PageIndex,
                  size: request.PageRequest.PageSize,
                  cancellationToken: cancellationToken
                 );

            GetListResponse<GetListTableListItemDto> response = _mapper.Map<GetListResponse<GetListTableListItemDto>>(Tables);
            return response;
        }
    }
}
