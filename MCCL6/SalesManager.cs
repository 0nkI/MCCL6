﻿using MCCL6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9MCCL6
{
    internal class SalesManager
    {
        IDBItem<Car> dbCar;

        public SalesManager(IDBItem<Car> dbCar)
        {
            this.dbCar = dbCar;
        }

        public void CreateCar()
        {
            Console.Write("Car Brand?: ");
            string carBrand = Console.ReadLine();
            Console.Write("Car Model?: ");
            string carModel = Console.ReadLine();
            Car car = new Car(carBrand, carModel);
            dbCar.AddItem(car);
        }

        public void GetCar()
        {
            Console.Write("Get car ID?: ");
            int id = int.Parse(Console.ReadLine());

            Car result = dbCar.FindById(id);
            if(result == default(Car))
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
        public void DeleteCar()
        {
            Console.Write("Delete Car ID?: ");
            int id = int.Parse(Console.ReadLine());
            Car result = dbCar.FindById(id);
            if (dbCar.DeleteByItem(result))
            {
                Console.WriteLine("Deleted");
            }
            else
            {
                Console.WriteLine("Not Deleted");
            }
        }
    }
}

