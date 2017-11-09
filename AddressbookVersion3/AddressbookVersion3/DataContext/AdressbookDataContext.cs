namespace AddressbookVersion3.DataContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AdressbookDataContext : DbContext
    {
        public AdressbookDataContext()
            : base("name=AdressbookDataContext")
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressContactLink> AddressContactLink { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasMany(e => e.AddressContactLink)
                .WithOptional(e => e.Address)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Contact>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
