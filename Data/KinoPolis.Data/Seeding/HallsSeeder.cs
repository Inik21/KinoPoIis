namespace KinoPolis.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using KinoPolis.Data.Models;

    public class HallsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            List<int> list = new List<int>();
            var halls = new List<(int NumberofHall, int Rows, int SeatsPerRow, int CinemaId)>()
            {
                (1, 3, 4, 1),
                (1, 3, 3, 2),
                (1, 5, 3, 3),
            };
            foreach (var hall in halls)
            {
                if (dbContext.Halls.Any())
                {
                    return;
                }
                else
                {
                    await dbContext.Halls.AddAsync(new Hall
                    {
                        NumberofHall = hall.NumberofHall,
                        Rows = hall.Rows,
                        SeatsPerRow = hall.SeatsPerRow,
                        CinemaId = hall.CinemaId,
                    });
                }
            }
        }
    }
}
