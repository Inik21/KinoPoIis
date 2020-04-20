namespace KinoPolis.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using KinoPolis.Data.Models;

    public class CinemasSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var cinemas = new List<(string Name, string Address)>
            {
                ("Paradise KinoPolis", @"bulevard ""Cherni vrah"" 100, 1407 Hladilnika, Sofia"),
                ("Sofia Ring Mall KinoPolis", @"ul. ""Okolovrasten pat"" 214, 1434 Simeonovo - Sever, Sofia"),
                ("Mall Of Sofia KinoPolis", "Sofia, 101 A. Stamboliyski Blvd 1303, 1303 Sofia"),
            };
            if (dbContext.Cinemas.Any())
            {
                return;
            }
            else
            {
                foreach (var cinema in cinemas)
                {
                    await dbContext.Cinemas.AddAsync(new Cinema
                    {
                        Name = cinema.Name,
                        Address = cinema.Address,
                    });
                }
            }
        }
    }
}
