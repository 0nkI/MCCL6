using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9MCCL6
{
    internal class SalesManagerMenu
    {
        SalesManager salesManager;

        public SalesManagerMenu(SalesManager salesManager)
        {
            this.salesManager = salesManager;
        }

        public void Run()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("SalesManagerMenu");
                Console.WriteLine("1-Create Car");
                Console.WriteLine("2-Find Car");
                Console.WriteLine("3-Delete Car");
                Console.WriteLine("4-Exit");
                int menuNumber = int.Parse(Console.ReadLine());
                switch (menuNumber)
                {
                    case 1:
                        salesManager.CreateCar();
                        break;

                    case 2:
                        salesManager.GetCar();
                        Console.ReadKey();
                        break;
                    case 3: 
                        Console.WriteLine("Delete Car");
                        Console.ReadKey();
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("ErrorNumber");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
