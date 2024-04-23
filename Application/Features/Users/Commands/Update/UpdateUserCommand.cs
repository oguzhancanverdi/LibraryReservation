using Application.Features.Users.Commands.Update;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Commands.Update;

public class UpdateUserCommand : IRequest<UpdatedUserResponse>
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UpdatedUserResponse>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IUserRepository UserRepository, IMapper mapper)
        {
            _UserRepository = UserRepository;
            _mapper = mapper;
        }

        public async Task<UpdatedUserResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            User? User = await _UserRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

            User = _mapper.Map(request, User);

            await _UserRepository.UpdateAsync(User);

            UpdatedUserResponse response = _mapper.Map<UpdatedUserResponse>(User);

            return response;
        }
    }
}
