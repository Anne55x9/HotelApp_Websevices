namespace HotelApp_Websevices
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GuestBookContext : DbContext
    {
        public GuestBookContext()
            : base("name=GuestBookContext")
        {
        }

        public virtual DbSet<GuestBookView> GuestBookView { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GuestBookView>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<GuestBookView>()
                .Property(e => e.Address)
                .IsUnicode(false);
        }
    }
}
