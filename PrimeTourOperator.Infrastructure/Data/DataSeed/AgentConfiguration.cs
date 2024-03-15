using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrimeTourOperator.Infrastructure.Data.Models;

namespace PrimeTourOperator.Infrastructure.Data.DataSeed
{
    internal class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            var data = new SeedData();
            builder.HasData(new Agent[] { data.Agent });
        }
    }
}
