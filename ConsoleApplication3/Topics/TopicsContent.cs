using PubSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub
{
	public class TopicsContent
	{

		public TopicsContent()
		{
		}
		

		public Message AnimalTopics()
		{
			return new Message { topic = "Animals", topicDescription = "Animals are Gods creation!!!" };

		}

		public Message RobotTopics()
		{
			return new Message { topic = "Robot", topicDescription = "Robots are mans creation!!!" };
		}

	}
}
