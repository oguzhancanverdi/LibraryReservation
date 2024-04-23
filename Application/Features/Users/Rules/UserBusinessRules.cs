using Application.Features.Users.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Rules;

public class UserBusinessRules : BaseBusinessRules
{
    private readonly IUserRepository _UserRepository;

    public UserBusinessRules(IUserRepository UserRepository)
    {
        _UserRepository = UserRepository;
    }

    public async Task UserUserNameCannotBeDuplicatedWhenInserted(string userName)
    {
        User? result = await _UserRepository.GetAsync(predicate: b => b.UserName == userName);

        if (result != null)
        {
            throw new BusinessException(UsersMessages.UserNumberExists);
        }
    }
}

