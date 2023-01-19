using System;
namespace FactoryPattern
{
	public class Motorcycle : IVehicle
	{
		public Motorcycle()
		{
		}

		public void Drive()
		{
			Console.WriteLine("The motorcyle is ready to ride");
		}
	}
}

