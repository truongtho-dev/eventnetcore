using Event.Arguments;
using Event.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Services
{
	class SubService
	{
		private Pub _pub;
		public void OnEventOccur(object sender, PubEventArgs args)
		{
			_pub = args.Pub;
		}

		public void HandleWhenEventOccur()
		{
			Console.WriteLine($"Note: {_pub.Name} event occur with the content: {_pub.Content}");
		}
	}
}
