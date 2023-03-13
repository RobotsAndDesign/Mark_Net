using MarkNet.Core.Entities.SystemLogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MarkNet.Infrastructure.SchemaDefinitions.SystemLogs
{
    public class SystemLogSchemaDefinition<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class, ISystemLogEntity
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(col => col.Id);
            builder.HasIndex(tl => tl.Created);
        }
    }
}
