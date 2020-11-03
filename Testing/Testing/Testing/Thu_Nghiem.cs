namespace Testing
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Thu_Nghiem : DbContext
    {
        public Thu_Nghiem()
            : base("name=Thu_Nghiem")
        {
        }

        public virtual DbSet<SaveFile> SaveFiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
