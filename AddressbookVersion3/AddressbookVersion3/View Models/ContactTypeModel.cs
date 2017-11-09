using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressbookVersion3.View_Models
{
    public class ContactTypeModel
    {
        public string ContactType1 { get; set; }

        public int ContactId { get; set; }

        public virtual Contact Contact { get; set; }
    }
}
