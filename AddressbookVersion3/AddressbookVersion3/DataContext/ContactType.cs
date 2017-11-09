namespace AddressbookVersion3.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactType")]
    public partial class ContactType
    {

        public int Id { get; set; }

        [StringLength(50)]
        public string ContactType1 { get; set; }

        public int? ContactId { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
