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

public class ReservationBusinessRules : BaseBusinessRules
{
    private readonly IReservationRepository _ReservationRepository;

    public ReservationBusinessRules(IReservationRepository ReservationRepository)
    {
        _ReservationRepository = ReservationRepository;
    }

    public async Task ReservationUserCheckWhenInserted(Guid userId)
    {
        if (LastWeekReservationCheck(userId).Result)
        {
            throw new BusinessException(ReservationsMessages.ReservationUserCheck);
        }
    }

    public async Task<bool> LastWeekReservationCheck(Guid userId)
    {
        DateTime currentDate = DateTime.Now;
        DateTime lastWeekDate = currentDate.AddDays(-7);

        Paginate<Reservation> result = await _ReservationRepository.GetListAsync(predicate: r => r.UserId == userId && r.StartTime >= lastWeekDate && r.StartTime <= currentDate);

        if (result.Count > 1)
        {
            return true;
        }

        return false;
    }
}

