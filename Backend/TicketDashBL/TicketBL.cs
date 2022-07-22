using TicketDashModel;
using TicketDashDL;

namespace TicketDashBL;

public class TicketDashBL : ITicketBL
{
    private IRepository _repo;

    public TicketBL(IRepository p_repo)
    {
        _repo = p_repo;

    }

    public Ticket CreateTicket()
    {
        return _repo.CreateTicket();
    }

    public List<Ticket> GetAllTickets()
    {
        return _repo.GetAllTickets();
    }

    public Ticket GetTicket(int TicketID)
    {
        return _repo.GetTicket(TicketID);
    }
}