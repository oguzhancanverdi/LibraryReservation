﻿using Application.Features.Reservations.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reservations.Rules;

public class ReservationBusinessRules: BaseBusinessRules
{
    private readonly IReservationRepository _ReservationRepository;

    public ReservationBusinessRules(IReservationRepository ReservationRepository)
    {
        _ReservationRepository = ReservationRepository;
    }

    public async Task ReservationNameCannotBeDuplicatedWhenInserted(string name)
    {
        Reservation? result = await _ReservationRepository.GetAsync(predicate: b => b.Name.ToLower() == name.ToLower());

        if (result != null)
        {
            throw new BusinessException(ReservationsMessages.ReservationNameExists);
        }
    }
}

