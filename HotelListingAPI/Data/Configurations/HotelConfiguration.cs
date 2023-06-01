using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListingAPI.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
