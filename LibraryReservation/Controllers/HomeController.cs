using Application.Features.Reservations.Queries.GetList;
using Application.Features.Rooms.Queries.GetList;
using Application.Features.Seats.Queries.GetList;
using Application.Features.Tables.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Domain.Entities;
using LibraryReservation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LibraryReservation.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var list = GetListAsync();
            return View(list.Result);
        }

        public IActionResult Privacy()
        {
            var list = GetListAsyncHistory(new Guid("0342d92e-7075-4e46-a873-a2df245635c8"));
            return View(list.Result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<LibraryViewModel> GetListAsync()
        {
            PageRequest pageRequest = new() { PageIndex = 0, PageSize = 100 };

            GetListRoomQuery getListRoomQuery = new() { PageRequest = pageRequest };
            GetListResponse<GetListRoomListItemDto> responseRoom = await Mediator.Send(getListRoomQuery);

            GetListTableQuery getListTableQuery = new() { PageRequest = pageRequest };
            GetListResponse<GetListTableListItemDto> responseTable = await Mediator.Send(getListTableQuery);

            GetListSeatQuery getListSeatQuery = new() { PageRequest = pageRequest };
            GetListResponse<GetListSeatListItemDto> responseSeat = await Mediator.Send(getListSeatQuery);

            LibraryViewModel libraryViewModel = new()
            {
                Rooms = responseRoom,
                Tables = responseTable,
                Seats = responseSeat
            };

            return libraryViewModel;
        }

        public async Task<HistoryViewModel> GetListAsyncHistory(Guid userId)
        {
            GetListByUserIdReservationQuery getListByUserIdReservationQuery = new() { UserId = userId };
            GetListResponse<GetListByUserIdReservationListItemDto> response = await Mediator.Send(getListByUserIdReservationQuery);

            HistoryViewModel historyViewModel = new()
            {
                Reservations = response
            };

            return historyViewModel;
        }
    }
}
