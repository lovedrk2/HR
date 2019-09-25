using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EF.Configer
{
   public class StudentConfiger : EntityTypeConfiguration<Student>
    {
        public StudentConfiger()
        {
            this.ToTable(nameof(Student));
            this.Property(e => e.Name).HasMaxLength(20);
        }
    }
}
