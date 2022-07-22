using TicketDashModel;

namespace TicketDashDL;

public interface IRepository
{
    TicketDashBL CreateTicket(Ticket p_ticket);
}