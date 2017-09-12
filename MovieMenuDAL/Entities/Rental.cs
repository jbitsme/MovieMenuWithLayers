using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuDAL.Entities
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
