using Event.Model;
using Event.Services;
using System;

namespace Event
{
	class Program
	{
		static void Main(string[] args)
		{
			var pub = new Pub
			{
				Name = "Bitcoin",
				Content = "Bitcoin increasing with 40% !!!"
			};

			var pubService = new PubService();
			var subService = new SubService();

			// register event: method that register must have similar signature with delegate
			pubService.Event += subService.OnEventOccur;

			pubService.HandleBusinessLogic(pub);
			subService.HandleWhenEventOccur();

			Console.ReadLine();
		}
	}
}
