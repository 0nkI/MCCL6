using _9MCCL6;
using MCCL6;

IDBItem<Car> dbCar = new DBItem<Car>();
Car car1 = new Car("Porsche", "911");
dbCar.AddItem(car1);

Car car2 = new Car("Porsche", "Panamera");
dbCar.AddItem(car2);

SalesManager salesManager = new SalesManager(dbCar);
SalesManagerMenu salesManagerMenu = new SalesManagerMenu(salesManager);
salesManagerMenu.Run();
foreach (Car car in dbCar.Items)
{
    Console.WriteLine(car);
}

Console.ReadKey();