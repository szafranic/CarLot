using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
	public class UsedCar : Car
	{
		public double Mileage { get; set; }
		public UsedCar(string Make, string Model, int Year, decimal Price, double Mileage) 
				: base(Make, Model, Year, Price) // get these from the parent, we can do what we need but they can help :)
		{
			this.Mileage = Mileage;
		}
		public UsedCar()
		{

		}
		public override string ToString()
		{
		
			return base.ToString() +$"\t{Mileage} -used-";
		}
		public void BuyBack(List<Car> carsInventory)
		{
			Console.WriteLine("thanks for offering your car, please enter some details");
			Console.Write("Make: ");
			string make = Console.ReadLine();
			Console.Write("Model: ");
			string model = Console.ReadLine();
			Console.Write("Year: ");
			int year = int.Parse(Console.ReadLine());
			Console.Write("Mileage: ");
			double mileage = double.Parse(Console.ReadLine());
			decimal price = (year % 100) * 1000 + 99.99m;
			UsedCar buying = new(make, model, year, price, mileage);
			carsInventory.Add(buying);
			Console.WriteLine("alright we will be paying $"+price);

		}
	}
}
