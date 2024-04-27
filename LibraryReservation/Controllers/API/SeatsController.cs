using Application.Features.Reservations.Commands.Update;
using Application.Features.Seats.Commands.Update;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryReservation.Controllers.API;

[Route("api/[controller]")]
[ApiController]
public class SeatsController : BaseController
{
    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateSeatCommand updateSeatCommand)
    {
        UpdatedSeatResponse response = await Mediator.Send(updateSeatCommand);
        return Ok(response);
    }
}
