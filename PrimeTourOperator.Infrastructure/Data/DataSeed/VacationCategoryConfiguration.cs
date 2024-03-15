using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeTourOperator.Infrastructure.Data.Models;

namespace PrimeTourOperator.Infrastructure.Data.DataSeed
{
    internal class VacationCategoryConfiguration : IEntityTypeConfiguration<VacationCategory>
    {
        public void Configure(EntityTypeBuilder<VacationCategory> builder)
        {
            var data = new SeedData();
            builder.HasData(new VacationCategory[] { data.SeaCategory, data.MountainCategory, data.SpaCategory });
        }
    }
}
