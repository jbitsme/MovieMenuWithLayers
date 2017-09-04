using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuBLL.BO
{
    public class UserBO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}
