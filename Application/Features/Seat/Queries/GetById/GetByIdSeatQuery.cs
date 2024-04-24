using Application.Features.Seats.Queries.GetById;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Seats.Queries.GetById;

public class GetByIdSeatQuery : IRequest<GetByIdSeatResponse>
{
    public Guid Id { get; set; }

    public class GetByIdSeatQueryHandler : IRequestHandler<GetByIdSeatQuery, GetByIdSeatResponse>
    {
        private readonly IMapper _mapper;
        private readonly ISeatRepository _SeatRepository;

        public GetByIdSeatQueryHandler(IMapper mapper, ISeatRepository SeatRepository)
        {
            _mapper = mapper;
            _SeatRepository = SeatRepository;
        }

        public async Task<GetByIdSeatResponse> Handle(GetByIdSeatQuery request, CancellationToken cancellationToken)
        {
            Seat? Seat = await _SeatRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken, withDeleted: true);

            GetByIdSeatResponse response = _mapper.Map<GetByIdSeatResponse>(Seat);

            return response;
        }
    }
}
