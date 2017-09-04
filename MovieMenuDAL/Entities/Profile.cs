using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuDAL.Entities
{
    public class Profile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNr { get; set; }
    }
}
