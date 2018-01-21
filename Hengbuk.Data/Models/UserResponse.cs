using System;
using System.Collections.Generic;
using System.Text;

namespace Hengbuk.Data.Models
{
    public class UserResponse : Common
    {
        public long userid { get; set; }
        public long total { get; set; }

        public virtual ICollection<UserResponseLines> answers { get; set; }
    }
}
