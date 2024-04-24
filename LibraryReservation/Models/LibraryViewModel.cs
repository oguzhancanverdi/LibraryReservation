using Application.Features.Rooms.Queries.GetList;
using Application.Features.Seats.Queries.GetList;
using Application.Features.Tables.Queries.GetList;
using Core.Application.Responses;

namespace LibraryReservation.Models;

public class LibraryViewModel
{
	public GetListResponse<GetListRoomListItemDto> Rooms { get; set; }
	public GetListResponse<GetListTableListItemDto> Tables { get; set; }
	public GetListResponse<GetListSeatListItemDto> Seats { get; set; }
}
