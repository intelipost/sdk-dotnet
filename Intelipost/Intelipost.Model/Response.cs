using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelipost.Model
{
    class Response
    {
        public string Status { get; set; }
        public string Messages { get; set; }
        public object Content { get; set; }
        public string Time { get; set; }
    }
}
