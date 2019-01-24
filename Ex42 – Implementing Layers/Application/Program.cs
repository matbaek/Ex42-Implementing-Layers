using Ex42___Implementing_Layers.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex42___Implementing_Layers
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        void Run()
        {
            Menu menu = new Menu();
            menu.Run();
        }
    }
}
