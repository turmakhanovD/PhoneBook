using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityPhoneBookApp
{
    public class PhoneNumber : Entity
    {
        public string Number { get; set; }
        public string OwnerName { get; set; }
        public Guid CityId { get; set; }
    }
}
