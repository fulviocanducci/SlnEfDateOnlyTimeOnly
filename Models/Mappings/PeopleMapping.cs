using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Mappings
{
   internal class PeopleMapping : IEntityTypeConfiguration<People>
   {
      public void Configure(EntityTypeBuilder<People> builder)
      {
         builder.ToTable("peoples");
         builder.HasKey(c => c.Id);

         builder.Property(c => c.Id).HasColumnName("id").UseMySqlIdentityColumn();
         builder.Property(c => c.Name).HasColumnName("name").HasMaxLength(100).IsRequired();
         builder.Property(c => c.CreatedAt).HasColumnName("created_at").HasColumnType("DATE").IsRequired();
         builder.Property(c => c.TimeAt).HasColumnName("time_at").HasColumnType("TIME").IsRequired();
      }
   }
}
