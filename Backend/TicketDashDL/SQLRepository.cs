using TicketDashModel;

namespace TicketDashDL;

public class SQLRepository : IRepository
{
    private readonly string _connectionString;

    public SQLRepository(string p_connectionString)
    {
        _connectionString = p_connectionString;
    }

    public TicketDashBL CreateTicket(Ticket p_ticket)
    {
        // create sql statement
        // open connection
        // run sql statement
    }
}