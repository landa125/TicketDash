using Microsoft.AspNetCore.Mvc;

namespace TicketDashAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TicketDashController : ControllerBase
{
    private ITicketBL _userBL;
    private IMemoryCache _memoryCache;

    public TicketDashController(ITicketDashBL p_ticketBL, IMemoryCache p_memorycache)
    {
        _ticketBL = p_ticketBL;
        _memoryCache = p_memorycache;

    }


    [HttpGet(Name = "GetAllTickets")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
