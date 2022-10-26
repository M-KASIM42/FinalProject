using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PercistanceLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercistanceLayer.DAL.EfCore.Config
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.EmployeeId);

            builder.Property(a => a.Age)
                .HasDefaultValue(20);
            builder.Property(a => a.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(a => a.LastName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Ignore(a => a.FullName);
            builder.Property(a => a.OnCreatedDate)
                .HasDefaultValue(DateTime.Now);
            builder.Property(a => a.Gender)
                .HasMaxLength(50);
            

        }
    }
}
