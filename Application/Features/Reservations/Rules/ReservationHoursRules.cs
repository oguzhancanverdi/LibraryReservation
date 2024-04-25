using Application.Features.Reservations.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reservations.Rules;

public class ReservationHoursRules : BaseBusinessRules
{
    private readonly IReservationRepository _ReservationRepository;

    public ReservationHoursRules(IReservationRepository ReservationRepository)
    {
        _ReservationRepository = ReservationRepository;
    }

    public async Task ReservationLibraryClosedWhenInserted()
    {
        if (!IsLibraryOpen(DateTime.Now).Result)
        {
            throw new BusinessException(ReservationsMessages.ReservationLibraryClosed);
        }
    }

    public async Task<bool> IsLibraryOpen(DateTime dateTime)
    {
        if (dateTime.DayOfWeek == DayOfWeek.Monday)
        {
            return false;
        }

        TimeSpan openingTime = new TimeSpan(9, 0, 0);
        TimeSpan closingTime = new TimeSpan(18, 0, 0);
        TimeSpan currentTime = dateTime.TimeOfDay;

        return currentTime >= openingTime && currentTime <= closingTime;
    }
}
