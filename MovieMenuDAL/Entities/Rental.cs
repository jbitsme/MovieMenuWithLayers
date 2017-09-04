using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuDAL.Entities
{
    public class Rental
    {
        public int Id { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
    }
}
