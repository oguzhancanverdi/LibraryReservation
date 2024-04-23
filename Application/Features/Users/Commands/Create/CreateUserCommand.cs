using Application.Features.Users.Commands.Create;
using Application.Features.Users.Rules;
using Application.Features.Users.Commands.Create;
using Application.Features.Users.Rules;
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

namespace Application.Features.Users.Commands.Create;

public class CreateUserCommand : IRequest<CreatedUserResponse>, ITransactionalRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreatedUserResponse>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IMapper _mapper;
        private readonly UserBusinessRules _UserBusinessRules;

        public CreateUserCommandHandler(IUserRepository UserRepository, IMapper mapper, UserBusinessRules UserBusinessRules)
        {
            _UserRepository = UserRepository;
            _mapper = mapper;
            _UserBusinessRules = UserBusinessRules;
        }

        public async Task<CreatedUserResponse>? Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            await _UserBusinessRules.UserUserNameCannotBeDuplicatedWhenInserted(request.UserName);

            User User = _mapper.Map<User>(request);
            User.Id = Guid.NewGuid();

            var result = await _UserRepository.AddAsync(User);

            CreatedUserResponse createdUserResponse = _mapper.Map<CreatedUserResponse>(result);

            return createdUserResponse;
        }
    }
}