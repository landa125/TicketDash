using TicketDashModel;

namespace TicketDashBL;

public interface ITicketBL
{
    List<Ticket> GetAllTickets();
    Ticket GetTicket(int TicketID);
}