using Application.Features.Seats.Commands.Update;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Seats.Commands.Update;

public class UpdateSeatCommand : IRequest<UpdatedSeatResponse>
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public Guid TableId { get; set; }
    public bool IsReserved { get; set; }

    public class UpdateSeatCommandHandler : IRequestHandler<UpdateSeatCommand, UpdatedSeatResponse>
    {
        private readonly ISeatRepository _SeatRepository;
        private readonly IMapper _mapper;

        public UpdateSeatCommandHandler(ISeatRepository SeatRepository, IMapper mapper)
        {
            _SeatRepository = SeatRepository;
            _mapper = mapper;
        }

        public async Task<UpdatedSeatResponse> Handle(UpdateSeatCommand request, CancellationToken cancellationToken)
        {
            Seat? Seat = await _SeatRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

            //Seat = _mapper.Map(request, Seat);

            Seat.IsReserved = request.IsReserved;

            await _SeatRepository.UpdateAsync(Seat);

            UpdatedSeatResponse response = _mapper.Map<UpdatedSeatResponse>(Seat);

            return response;
        }
    }
}
