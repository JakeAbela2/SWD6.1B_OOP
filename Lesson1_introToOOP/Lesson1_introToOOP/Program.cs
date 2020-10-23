using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_introToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.IdCard = "3838383m"; //write

            p.Name = "Jake";
            p.Surname = "Abela";

            /*
            Console.WriteLine("Please press a key to continue");
            Console.ReadLine(); //this expects that the user clicks on the Enter key on the keyboard
            Console.WriteLine($"Name: {p.Name}, Surname: {p.Surname}, Id: {p.IdCard} ");
            Console.ReadKey(); //this expects that the user clicks any key on the keyboard
            */

            Console.WriteLine("Please input Address: ");
            p.Address = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(p.DelimitAddress(','));
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
    }
}
