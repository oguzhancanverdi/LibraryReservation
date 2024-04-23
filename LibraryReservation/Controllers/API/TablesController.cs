using Application.Features.Tables.Commands.Create;
using Application.Features.Tables.Commands.Delete;
using Application.Features.Tables.Commands.Update;
using Application.Features.Tables.Queries.GetById;
using Application.Features.Tables.Queries.GetList;
using Core.Application.Requests;
using Core.Application.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryReservation.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablesController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateTableCommand createTableCommand)
        {
            CreatedTableResponse response = await Mediator.Send(createTableCommand);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListTableQuery getListTableQuery = new() { PageRequest = pageRequest };
            GetListResponse<GetListTableListItemDto> response = await Mediator.Send(getListTableQuery);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            GetByIdTableQuery getByIdTableQuery = new() { Id = id };
            GetByIdTableResponse response = await Mediator.Send(getByIdTableQuery);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateTableCommand updateTableCommand)
        {
            UpdatedTableResponse response = await Mediator.Send(updateTableCommand);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            DeletedTableResponse response = await Mediator.Send(new DeleteTableCommand { Id = id });
            return Ok(response);
        }
    }
}
