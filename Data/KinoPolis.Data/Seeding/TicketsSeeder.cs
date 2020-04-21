using KinoPolis.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoPolis.Data.Seeding
{
    public class TicketsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var tickets = new List<(int Row, int Seat, int ProjectionId, bool IsReserved)>()
            {
                (1, 1, 12, true),
                (1, 2, 12, false),
                (1, 3, 12, false),
                (2, 4, 12, true),
                (2, 5, 12, false),
                (2, 6, 12, true),
                (3, 7, 12, false),
                (3, 8, 12, true),
                (3, 9, 12, false),
                (1, 1, 13, false),
                (1, 2, 13, true),
                (1, 3, 13, false),
                (1, 4, 13, true),
                (2, 5, 13, true),
                (2, 6, 13, true),
                (2, 7, 13, false),
                (2, 8, 13, false),
                (3, 9, 13, false),
                (3, 10, 13, true),
                (3, 11, 13, false),
                (3, 12, 13, true),
                (1, 1, 14, false),
                (1, 2, 14, true),
                (1, 3, 14, false),
                (2, 4, 14, true),
                (2, 5, 14, true),
                (2, 6, 14, false),
                (3, 7, 14, false),
                (3, 8, 14, true),
                (3, 9, 14, true),
                (4, 10, 14, false),
                (4, 11, 14, true),
                (4, 12, 14, false),
                (5, 13, 14, false),
                (5, 14, 14, true),
                (5, 15, 14, true),
            };

            foreach (var ticket in tickets)
            {
                if (dbContext.Tickets.Any())
                {
                    return;
                }
                else
                {
                    await dbContext.Tickets.AddAsync(new Ticket
                    {
                        Row = ticket.Row,
                        Seat = ticket.Seat,
                        ProjectionId = ticket.ProjectionId,
                        IsReserved = ticket.IsReserved,
                    });
                }
            }
        }
    }
}
