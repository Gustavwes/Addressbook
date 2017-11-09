namespace AddressbookVersion3.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AddressContactLink")]
    public partial class AddressContactLink
    {
        public int Id { get; set; }

        public int? ContactId { get; set; }

        public int? AddressId { get; set; }

        public virtual Address Address { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
