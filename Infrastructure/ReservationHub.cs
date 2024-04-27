using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure;

public class ReservationHub : Hub
{
    public async Task SendName(string name)
    {
        await Clients.Others.SendAsync("ReceiveName", name);
    }
}
