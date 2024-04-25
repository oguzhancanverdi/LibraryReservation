using Application.Features.Reservations.Commands.Create;
using Application.Features.Reservations.Commands.Delete;
using Application.Features.Reservations.Commands.Update;
using Application.Features.Reservations.Queries.GetById;
using Application.Features.Reservations.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryReservation.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateReservationCommand createReservationCommand)
        {
            createReservationCommand.UserId = new Guid("0342d92e-7075-4e46-a873-a2df245635c8");
            createReservationCommand.StartTime = DateTime.Now;
            CreatedReservationResponse response = await Mediator.Send(createReservationCommand);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListReservationQuery getListReservationQuery = new() { PageRequest = pageRequest };
            GetListResponse<GetListReservationListItemDto> response = await Mediator.Send(getListReservationQuery);
            return Ok(response);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetListByUserId([FromQuery] Guid userId)
        {
            GetListByUserIdReservationQuery getListByUserIdReservationQuery = new() { UserId = userId };
            GetListResponse<GetListByUserIdReservationListItemDto> response = await Mediator.Send(getListByUserIdReservationQuery);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateReservationCommand updateReservationCommand)
        {
            UpdatedReservationResponse response = await Mediator.Send(updateReservationCommand);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            DeletedReservationResponse response = await Mediator.Send(new DeleteReservationCommand { Id = id });
            return Ok(response);
        }
    }
}
