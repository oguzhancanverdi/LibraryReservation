using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Queries.GetByUserName;

public class GetByUserNameUserQuery : IRequest<GetByUserNameUserResponse>
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public class GetByUserNameUserQueryHandler : IRequestHandler<GetByUserNameUserQuery, GetByUserNameUserResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _UserRepository;

        public GetByUserNameUserQueryHandler(IMapper mapper, IUserRepository UserRepository)
        {
            _mapper = mapper;
            _UserRepository = UserRepository;
        }

        public async Task<GetByUserNameUserResponse> Handle(GetByUserNameUserQuery request, CancellationToken cancellationToken)
        {
            User? User = await _UserRepository.GetAsync(predicate: b => b.UserName == request.UserName && b.Password == request.Password, cancellationToken: cancellationToken, withDeleted: true);

            GetByUserNameUserResponse response = _mapper.Map<GetByUserNameUserResponse>(User);

            return response;
        }
    }
}
