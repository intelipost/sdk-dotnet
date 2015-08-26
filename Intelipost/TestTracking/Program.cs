using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intelipost.API;


namespace TestTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Tracking tr = new Tracking("http://localhost:7777/");
        }
    }
}
