using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PercistanceLayer.Entities;

namespace PercistanceLayer.DAL.EfCore.Config
{
    public class EmployeeDetailConfig : IEntityTypeConfiguration<EmployeeDetail>
    {
        public void Configure(EntityTypeBuilder<EmployeeDetail> builder)
        {
            builder.HasKey(a => a.EmployeeDetailId);
            builder.Property(a => a.Email)
                .HasMaxLength(50);
            builder.Property(a => a.Salary)
                .HasMaxLength(50);
            builder.Property(a => a.Phone)
                .HasMaxLength(50);
            builder.Property(a => a.Experience)
                .HasMaxLength(10);
            builder.Property(a => a.Education)
                .HasMaxLength(50);
            builder.Property(a => a.Occupation)
                .HasMaxLength(50);


            builder.HasOne(bd => bd.Employee)
                .WithOne(b => b.EmployeeDetail)
                .HasForeignKey<EmployeeDetail>(bd => bd.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
