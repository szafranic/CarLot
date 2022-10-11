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
		public override string ToString()
		{
		
			return base.ToString() +$"\t{Mileage}";
		}
	}
}
