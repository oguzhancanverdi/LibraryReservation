using Application.Features.Tables.Commands.Delete;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tables.Commands.Delete;

public class DeleteTableCommand : IRequest<DeletedTableResponse>
{
    public Guid Id { get; set; }

    public class DeleteTableCommandHandler : IRequestHandler<DeleteTableCommand, DeletedTableResponse>
    {
        private readonly ITableRepository _TableRepository;
        private readonly IMapper _mapper;

        public DeleteTableCommandHandler(ITableRepository TableRepository, IMapper mapper)
        {
            _TableRepository = TableRepository;
            _mapper = mapper;
        }

        public async Task<DeletedTableResponse>? Handle(DeleteTableCommand request, CancellationToken cancellationToken)
        {
            Table? Table = await _TableRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

            await _TableRepository.DeleteAsync(Table);

            DeletedTableResponse response = _mapper.Map<DeletedTableResponse>(Table);

            return response;
        }
    }
}