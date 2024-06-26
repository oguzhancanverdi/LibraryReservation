﻿using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Queries.GetList;

public class GetListUserQuery : IRequest<GetListResponse<GetListUserListItemDto>>
{
    public PageRequest PageRequest { get; set; }

    public class GetListUserQueryHandler : IRequestHandler<GetListUserQuery, GetListResponse<GetListUserListItemDto>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IMapper _mapper;

        public GetListUserQueryHandler(IUserRepository UserRepository, IMapper mapper)
        {
            _UserRepository = UserRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListUserListItemDto>> Handle(GetListUserQuery request, CancellationToken cancellationToken)
        {
            Paginate<User> Users = await _UserRepository.GetListAsync(
                  index: request.PageRequest.PageIndex,
                  size: request.PageRequest.PageSize,
                  cancellationToken: cancellationToken
                 );

            GetListResponse<GetListUserListItemDto> response = _mapper.Map<GetListResponse<GetListUserListItemDto>>(Users);
            return response;
        }
    }
}
