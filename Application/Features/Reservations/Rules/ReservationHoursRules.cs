using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reservations.Rules;

public static class ReservationHoursRules
{
    public static bool IsLibraryOpen(DateTime dateTime)
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
