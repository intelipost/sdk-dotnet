using Intelipost.Util;
using System;
using System.IO;

namespace Intelipost.Infrastructure.Log
{
    public class Logger
    {
        public void Insert(string plainText)
        {
            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var completePath = String.Format("{0}/intelipost_{1}.log", path, DateTime.Now.ToString("ddMMyyyyHHss"));

            File.WriteAllText(completePath, Base64.Encode(plainText));
        }
    }
}