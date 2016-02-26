namespace WTeaTime.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TeaContext : DbContext
    {
        public TeaContext()
            : base("name=TeaContext")
        {
        }

        public virtual DbSet<TeaEntityRow> TeaEntity { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
