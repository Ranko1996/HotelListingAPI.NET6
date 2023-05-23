﻿using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Data
{
    public class HotelListingDbConext : DbContext
    {
        public HotelListingDbConext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                    new Country
                    {
                        Id = 1,
                        Name = "Croatia",
                        ShortName = "CRO"

                    },
                    new Country
                    {
                        Id = 2,
                        Name = "Maldives",
                        ShortName = "ML"

                    },
                    new Country
                    {
                        Id = 3,
                        Name = "Spain",
                        ShortName = "ES"

                    }
                );

            modelBuilder.Entity<Hotel>().HasData(
                    new Hotel
                    {
                        Id = 1,
                        Name = "Sandals Resort and Spa",
                        Address = "Zadar 14a",
                        CountryId = 1,
                        Rating = 4.5
                    },
                     new Hotel
                     {
                         Id = 2,
                         Name = "Butch and Cassidy",
                         Address = "Eiland 2 14a",
                         CountryId = 2,
                         Rating = 4.3
                     },
                      new Hotel
                      {
                          Id = 3,
                          Name = "Resort and Spa",
                          Address = "Barca 14a",
                          CountryId = 3,
                          Rating = 4.6
                      }
                );
        }
    }
}