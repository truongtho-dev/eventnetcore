using Event.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Arguments
{
	class PubEventArgs: EventArgs
	{
		public Pub Pub { get; set; }
	}
}
