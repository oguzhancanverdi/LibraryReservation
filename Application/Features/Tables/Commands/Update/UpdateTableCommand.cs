using Application.Features.Tables.Commands.Update;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tables.Commands.Update;

public class UpdateTableCommand : IRequest<UpdatedTableResponse>
{
    public Guid Id { get; set; }
    public int Number { get; set; }
    public Guid TableId { get; set; }

    public class UpdateTableCommandHandler : IRequestHandler<UpdateTableCommand, UpdatedTableResponse>
    {
        private readonly ITableRepository _TableRepository;
        private readonly IMapper _mapper;

        public UpdateTableCommandHandler(ITableRepository TableRepository, IMapper mapper)
        {
            _TableRepository = TableRepository;
            _mapper = mapper;
        }

        public async Task<UpdatedTableResponse> Handle(UpdateTableCommand request, CancellationToken cancellationToken)
        {
            Table? Table = await _TableRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

            Table = _mapper.Map(request, Table);

            await _TableRepository.UpdateAsync(Table);

            UpdatedTableResponse response = _mapper.Map<UpdatedTableResponse>(Table);

            return response;
        }
    }
}
