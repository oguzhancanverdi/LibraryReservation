using Application.Features.Seats.Commands.Delete;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Seats.Commands.Delete;

public class DeleteSeatCommand : IRequest<DeletedSeatResponse>
{
	public Guid Id { get; set; }

	public class DeleteSeatCommandHandler : IRequestHandler<DeleteSeatCommand, DeletedSeatResponse>
	{
		private readonly ISeatRepository _SeatRepository;
		private readonly IMapper _mapper;

		public DeleteSeatCommandHandler(ISeatRepository SeatRepository, IMapper mapper)
		{
			_SeatRepository = SeatRepository;
			_mapper = mapper;
		}

		public async Task<DeletedSeatResponse>? Handle(DeleteSeatCommand request, CancellationToken cancellationToken)
		{
			Seat? Seat = await _SeatRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

			await _SeatRepository.DeleteAsync(Seat);

			DeletedSeatResponse response = _mapper.Map<DeletedSeatResponse>(Seat);

			return response;
		}
	}
}