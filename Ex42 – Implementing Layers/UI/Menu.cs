using Ex42___Implementing_Layers.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex42___Implementing_Layers.UI
{
    public class Menu
    {
        public void Run()
        {
            Controller controller = new Controller();
            bool runWhileTrue = true;
            while (runWhileTrue)
            {
                Console.Clear();
                Console.WriteLine("1. Insert a pet");
                Console.WriteLine("2. Show all pets");
                int menuInput = int.Parse(Console.ReadLine());
                switch (menuInput)
                {
                    case 0:
                        runWhileTrue = false;
                        break;
                    case 1:
                        Console.WriteLine("==== Insert a Pet ====");
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Type: ");
                        string type = Console.ReadLine();
                        Console.Write("Breed: ");
                        string breed = Console.ReadLine();
                        Console.Write("DOB: ");
                        string dob = Console.ReadLine();
                        Console.Write("Weight: ");
                        int weight = int.Parse(Console.ReadLine());
                        controller.InsertPet(name, type, breed, dob, weight);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("==== Show all Pets ====");
                        controller.ShowPets();
                        Console.Clear();
                        break;
                    default:

                        break;
                }
            }

        }
    }
}
