using Application.Features.Rooms.Commands.Create;
using Application.Features.Rooms.Commands.Delete;
using Application.Features.Rooms.Commands.Update;
using Application.Features.Rooms.Queries.GetById;
using Application.Features.Rooms.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryReservation.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateRoomCommand createRoomCommand)
        {
            CreatedRoomResponse response = await Mediator.Send(createRoomCommand);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListRoomQuery getListRoomQuery = new() { PageRequest = pageRequest };
            GetListResponse<GetListRoomListItemDto> response = await Mediator.Send(getListRoomQuery);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            GetByIdRoomQuery getByIdRoomQuery = new() { Id = id };
            GetByIdRoomResponse response = await Mediator.Send(getByIdRoomQuery);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateRoomCommand updateRoomCommand)
        {
            UpdatedRoomResponse response = await Mediator.Send(updateRoomCommand);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            DeletedRoomResponse response = await Mediator.Send(new DeleteRoomCommand { Id = id });
            return Ok(response);
        }
    }
}
