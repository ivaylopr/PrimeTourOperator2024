using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeTourOperator.Infrastructure.Data.Models;

namespace PrimeTourOperator.Infrastructure.Data.DataSeed
{
    internal class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            var data = new SeedData();
            builder.HasData(new Room[] {data.BlackSeaTwoBed, data.BlackSeaStudio, data.BlackSeaPresidentApart,
                                        data.BanskoResortTwoBed, data.BanskoResortStudio, data.BanskoResortPresidentApart,
                                        data.PortoBelloTwoBed, data.PortoBelloStudio, data.PortoBelloPresidentApart});
        }
    }
}
