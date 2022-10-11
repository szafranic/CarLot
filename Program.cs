namespace CarLot
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Car c = new Car();

			List<Car> carsInventory = new List<Car>()
			{
				new UsedCar("Chevy","Maxx",2006,7000m,120000),
				new UsedCar("Subaru", "Impreza", 2003, 22999.95m, 199999),
				new UsedCar("Nissan", "r34", 2000, 41999.95m, 87320),
				new Car("Tesla", "Model 3", 2021, 49999.90m),
				new Car("Jeep", "Trackhawk", 2023, 99999.95m),
				new Car("Honda", "Type-R", 2021, 38500m)
		};


			int index = 1;
			foreach (Car car in carsInventory)
			{
				index++;
				Console.WriteLine(index + " " + car);
			}

			Console.WriteLine("which car would you like? select the index");
			string input = Console.ReadLine();
			int pick = int.Parse(input);
			carsInventory.RemoveAt(pick+1);

			index = 1;
			foreach (Car car in carsInventory)
			{
				index++;
				Console.WriteLine(index + " " + car);
			}

		}
	}
}