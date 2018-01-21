using System;
using System.Collections.Generic;
using System.Text;

namespace Hengbuk.Data.Models
{
    public class UserResponseLines : Common
    {
        public long userresponseid { get; set; }
        public long questionid { get; set; }
        public Question question { get; set; }
        public int answer { get; set; }
    }
}
