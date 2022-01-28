using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaconsaleWebApp.Models
{
    public class MovieApplicationContext : DbContext
    {
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base(options)
        {
            //leave blank
        }
        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    AppID = 1,
                    Category = "Action/Adventure",
                    Title = "Avengers, The",
                    Year = 2012,
                    Director = "Joss Whedon",
                    Rating = "PG-13",
                  

                },
                new ApplicationResponse
                {
                    AppID = 2,
                    Category = "Action/Adventure",
                    Title = "Batman",
                    Year = 1989,
                    Director = "Tim Burton",
                    Rating = "PG-13",
                },
                new ApplicationResponse
                {
                    AppID = 3,
                    Category = "Action/Adventure",
                    Title = "Dark Knight, The",
                    Year = 2008,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                }
                );
        }
    }

}
