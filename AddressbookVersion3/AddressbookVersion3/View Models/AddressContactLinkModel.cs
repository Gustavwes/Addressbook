using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressbookVersion3.View_Models
{
    public class AddressContactLinkModel
    {
        public int Id { get; set; }

        public int? ContactId { get; set; }

        public int? AddressId { get; set; }

        public  AddressModel Address { get; set; }

        public  Contact Contact { get; set; }
    }
}
