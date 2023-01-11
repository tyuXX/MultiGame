using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MultiGameUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void dowload(string link, string name)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(link, name);
            }
        }
    }
}
