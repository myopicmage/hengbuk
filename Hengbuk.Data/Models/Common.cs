using System;
using System.Collections.Generic;
using System.Text;

namespace Hengbuk.Data.Models
{
    public class Common
    {
        public long id { get; set; }
        public DateTime created { get; set; }
        public string createdby { get; set; }
        public DateTime modified { get; set; }
        public string modifiedby { get; set; }
    }
}
