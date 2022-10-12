namespace CarLot
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Car c = new Car();
			UsedCar u = new UsedCar();

			List<Car> carsInventory = new List<Car>()
			{
				new UsedCar("Chevy","Maxx",2006,7000.00m,120000),
				new UsedCar("Subaru", "Impreza", 2003, 22999.95m, 199999),
				new UsedCar("Nissan", "r34", 2000, 41999.95m, 87320),
				new Car("Tesla", "Model 3", 2021, 49999.90m),
				new Car("Jeep", "Trackhawk", 2023, 99999.95m),
				new Car("Honda", "Type-R", 2021, 38500.00m)
			};

			while (true)
			{
				Car.ListCars(carsInventory);
				Console.WriteLine("would you like to *buy* a car or *sell* a car?");
				string select = Console.ReadLine().ToLower();
				if (select == "buy")
				{
					Car.Remove(carsInventory);
				} else if(select == "sell")
				{
					//carsInventory.Add();
					u.BuyBack(carsInventory);

				}
			}

		}
	}
}