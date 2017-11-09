using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressbookVersion3.View_Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        
        public string StreetAddress { get; set; }
        
        public string PostalCode { get; set; }
        
        public string City { get; set; }
    }
}
