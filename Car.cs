using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CarLot
{
	public class Car
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public decimal Price { get; set; }
		public Car()
		{

		}
		public Car(string Make, string Model, int Year, decimal Price)
		{
			this.Make = Make;
			this.Model = Model;
			this.Year = Year;
			this.Price = Price;
		}
	 /*	public static void ListCars(List<Car> inv)
		{
			int index = 1;
			foreach (Car car in inv)
			{
				index++;
				Console.WriteLine(index + " " + car);
			}
		}*/

		public override string ToString()
		{
			string myString = $"{Make}\t{Model}\t\t{Year}\t{Price}";

			return myString;
		}

	}
}
