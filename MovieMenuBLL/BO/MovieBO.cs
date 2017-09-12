using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieMenuBLL.BO
{
    public class MovieBO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Length { get; set; }
        public string Auther { get; set; }
    }
}
