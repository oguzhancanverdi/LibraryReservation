using Application.Features.Seats.Rules;
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

namespace Application.Features.Seats.Commands.Create;

public class CreateSeatCommand : IRequest<CreatedSeatResponse>, ITransactionalRequest
{
    public string Name { get; set; }
    public Guid TableId { get; set; }
	public bool IsReserved { get; set; }

	public class CreateSeatCommandHandler : IRequestHandler<CreateSeatCommand, CreatedSeatResponse>
    {
        private readonly ISeatRepository _SeatRepository;
        private readonly IMapper _mapper;
        private readonly SeatBusinessRules _SeatBusinessRules;

        public CreateSeatCommandHandler(ISeatRepository SeatRepository, IMapper mapper, SeatBusinessRules SeatBusinessRules)
        {
            _SeatRepository = SeatRepository;
            _mapper = mapper;
            _SeatBusinessRules = SeatBusinessRules;
        }

        public async Task<CreatedSeatResponse>? Handle(CreateSeatCommand request, CancellationToken cancellationToken)
        {
            await _SeatBusinessRules.SeatNameCannotBeDuplicatedWhenInserted(request.Name);

            Seat Seat = _mapper.Map<Seat>(request);
            Seat.Id = Guid.NewGuid();

            var result = await _SeatRepository.AddAsync(Seat);

            CreatedSeatResponse createdSeatResponse = _mapper.Map<CreatedSeatResponse>(result);

            return createdSeatResponse;
        }
    }
}