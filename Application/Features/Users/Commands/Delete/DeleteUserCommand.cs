using Application.Features.Users.Commands.Delete;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Commands.Delete;

public class DeleteUserCommand : IRequest<DeletedUserResponse>
{
    public Guid Id { get; set; }

    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, DeletedUserResponse>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IMapper _mapper;

        public DeleteUserCommandHandler(IUserRepository UserRepository, IMapper mapper)
        {
            _UserRepository = UserRepository;
            _mapper = mapper;
        }

        public async Task<DeletedUserResponse>? Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            User? User = await _UserRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);

            await _UserRepository.DeleteAsync(User);

            DeletedUserResponse response = _mapper.Map<DeletedUserResponse>(User);

            return response;
        }
    }
}