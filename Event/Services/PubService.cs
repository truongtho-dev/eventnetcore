using Event.Arguments;
using Event.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Event.Services
{
	class PubService
	{
		// declare event
		public EventHandler<PubEventArgs> Event;

		public void HandleBusinessLogic(Pub pub)
		{
			Console.WriteLine("Handle something......and wait to event occur");

			// await until event occur
			Thread.Sleep(2000);
			OnEventOccur(pub);
		}

		protected virtual void OnEventOccur(Pub pub)
		{
			Event?.Invoke(this, new PubEventArgs { Pub = pub });
		}
	}
}
