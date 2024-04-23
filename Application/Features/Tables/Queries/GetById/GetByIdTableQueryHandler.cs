using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tables.Queries.GetById;

public class GetByIdTableQuery : IRequest<GetByIdTableResponse>
{
    public Guid Id { get; set; }

    public class GetByIdTableQueryHandler : IRequestHandler<GetByIdTableQuery, GetByIdTableResponse>
    {
        private readonly IMapper _mapper;
        private readonly ITableRepository _TableRepository;

        public GetByIdTableQueryHandler(IMapper mapper, ITableRepository TableRepository)
        {
            _mapper = mapper;
            _TableRepository = TableRepository;
        }

        public async Task<GetByIdTableResponse> Handle(GetByIdTableQuery request, CancellationToken cancellationToken)
        {
            Table? Table = await _TableRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken, withDeleted: true);

            GetByIdTableResponse response = _mapper.Map<GetByIdTableResponse>(Table);

            return response;
        }
    }
}
