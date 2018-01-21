using System;
using System.Collections.Generic;
using System.Text;

namespace Hengbuk.Data.Models
{
    public class User : Common
    {
        public string name { get; set; }
        public string username { get; set; }

        public virtual ICollection<UserResponse> responses { get; set; }
    }
}
