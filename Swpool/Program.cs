using Swpool.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swpool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PoolActionController controller = new PoolActionController();
            controller.Start();
        }
    }
}
