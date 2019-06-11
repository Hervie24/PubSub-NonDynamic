using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub
{
	public class SubscriberInfo
	{
		public string name;
		public List<topicTypes> topictype;

	}

	public class topicTypes
	{
		public bool isRobot;
		public bool isAnimal;
	}


}
