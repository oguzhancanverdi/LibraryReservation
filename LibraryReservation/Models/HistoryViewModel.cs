using Application.Features.Reservations.Queries.GetList;
using Core.Application.Responses;

namespace LibraryReservation.Models;

public class HistoryViewModel
{
    public Guid UserId { get; set; }
    public GetListResponse<GetListByUserIdReservationListItemDto> Reservations { get; set; }
}
