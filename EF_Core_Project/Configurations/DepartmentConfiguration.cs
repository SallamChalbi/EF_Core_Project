using EF_Core_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Project.Configurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(10, 10);
            builder.Property(D => D.HiringDate).HasComputedColumnSql("GetDate()");

            builder.HasMany(D => D.Instructors).WithOne(I => I.WorkFroDepartment).IsRequired(false)
                   .HasForeignKey(I => I.DepartmentId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(D => D.Manager).WithOne(I => I.ManageDepartment)
                   .HasForeignKey<Department>(D => D.ManagerId).IsRequired(false);
        }
    }
}
