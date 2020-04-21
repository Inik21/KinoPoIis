namespace KinoPolis.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using KinoPolis.Data.Models;

    public class ProjectionsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var projections = new List<(int Price, DateTime Time, int FilmId, int CinemaId, int HallId)>()
            {
                (18, new DateTime(2019, 12, 9, 17, 00, 0), 1, 2, 2),
                (14, new DateTime(2020, 2, 12, 11, 00, 0), 2, 1, 1),
                (8, new DateTime(2020, 3, 17, 13, 30, 0), 3, 3, 3),
            };
            if (dbContext.Projections.Any())
            {
                return;
            }
            else
            {
                foreach (var projection in projections)
                {
                    await dbContext.Projections.AddAsync(new Projection
                    {
                        Price = projection.Price,
                        Time = projection.Time,
                        FilmId = projection.FilmId,
                        CinemaId = projection.CinemaId,
                        HallId = projection.HallId,
                    });
                }
            }
        }
    }
}
