using Application.Features.Tables.Commands.Create;
using Application.Features.Tables.Rules;
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

namespace Application.Features.Tables.Commands.Create;

public class CreateTableCommand : IRequest<CreatedTableResponse>, ITransactionalRequest
{
    public int Number { get; set; }
    public bool IsReserved { get; set; }

    public class CreateTableCommandHandler : IRequestHandler<CreateTableCommand, CreatedTableResponse>
    {
        private readonly ITableRepository _TableRepository;
        private readonly IMapper _mapper;
        private readonly TableBusinessRules _TableBusinessRules;

        public CreateTableCommandHandler(ITableRepository TableRepository, IMapper mapper, TableBusinessRules TableBusinessRules)
        {
            _TableRepository = TableRepository;
            _mapper = mapper;
            _TableBusinessRules = TableBusinessRules;
        }

        public async Task<CreatedTableResponse>? Handle(CreateTableCommand request, CancellationToken cancellationToken)
        {
            await _TableBusinessRules.TableNumberCannotBeDuplicatedWhenInserted(request.Number);

            Table Table = _mapper.Map<Table>(request);
            Table.Id = Guid.NewGuid();

            var result = await _TableRepository.AddAsync(Table);

            CreatedTableResponse createdTableResponse = _mapper.Map<CreatedTableResponse>(result);

            return createdTableResponse;
        }
    }
}