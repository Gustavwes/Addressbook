namespace AddressbookVersion3.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address")]
    public partial class Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Address()
        {
            AddressContactLink = new HashSet<AddressContactLink>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string StreetAddress { get; set; }

        [StringLength(30)]
        public string PostalCode { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AddressContactLink> AddressContactLink { get; set; }
    }
}
