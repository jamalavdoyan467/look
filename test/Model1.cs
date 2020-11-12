namespace test
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Заказ> Заказ { get; set; }
        public virtual DbSet<Список_бригад> Список_бригад { get; set; }
        public virtual DbSet<список_видов_ремонта> список_видов_ремонта { get; set; }
        public virtual DbSet<Список_станков> Список_станков { get; set; }
        public virtual DbSet<Список_клиентов> Список_клиентов { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Список_бригад>()
                .HasMany(e => e.Заказ)
                .WithRequired(e => e.Список_бригад)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<список_видов_ремонта>()
                .Property(e => e.стоимость_работ__руб__)
                .HasPrecision(19, 4);

            modelBuilder.Entity<список_видов_ремонта>()
                .HasMany(e => e.Заказ)
                .WithRequired(e => e.список_видов_ремонта)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Список_станков>()
                .HasMany(e => e.Заказ)
                .WithRequired(e => e.Список_станков)
                .WillCascadeOnDelete(false);
        }
    }
}
