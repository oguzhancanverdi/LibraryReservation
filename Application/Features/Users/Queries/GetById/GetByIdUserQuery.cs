using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Queries.GetById;

public class GetByIdUserQuery : IRequest<GetByIdUserResponse>
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQuery, GetByIdUserResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _UserRepository;

        public GetByIdUserQueryHandler(IMapper mapper, IUserRepository UserRepository)
        {
            _mapper = mapper;
            _UserRepository = UserRepository;
        }

        public async Task<GetByIdUserResponse> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
        {
            User? User = await _UserRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken, withDeleted: true);

            GetByIdUserResponse response = _mapper.Map<GetByIdUserResponse>(User);

            return response;
        }
    }
}
