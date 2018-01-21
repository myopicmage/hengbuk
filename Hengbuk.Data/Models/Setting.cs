using System;
using System.Collections.Generic;
using System.Text;

namespace Hengbuk.Data.Models
{
    public class Setting : Common
    {
        public long userid { get; set; }
        public string key { get; set; }
        public string value { get; set; }
    }
}
