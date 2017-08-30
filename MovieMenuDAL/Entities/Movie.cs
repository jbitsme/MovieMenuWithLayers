using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuDAL.Entities
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Length { get; set; }
        public string Auther { get; set; }
        public int Id { get; set; }
    }
}
