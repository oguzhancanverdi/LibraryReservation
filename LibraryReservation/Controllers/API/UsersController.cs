using Application.Features.Users.Commands.Create;
using Application.Features.Users.Commands.Delete;
using Application.Features.Users.Commands.Update;
using Application.Features.Users.Queries.GetById;
using Application.Features.Users.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryReservation.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateUserCommand createUserCommand)
        {
            CreatedUserResponse response = await Mediator.Send(createUserCommand);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListUserQuery getListUserQuery = new() { PageRequest = pageRequest };
            GetListResponse<GetListUserListItemDto> response = await Mediator.Send(getListUserQuery);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            GetByIdUserQuery getByIdUserQuery = new() { Id = id };
            GetByIdUserResponse response = await Mediator.Send(getByIdUserQuery);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateUserCommand updateUserCommand)
        {
            UpdatedUserResponse response = await Mediator.Send(updateUserCommand);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            DeletedUserResponse response = await Mediator.Send(new DeleteUserCommand { Id = id });
            return Ok(response);
        }
    }
}
