using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListingAPI.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}
