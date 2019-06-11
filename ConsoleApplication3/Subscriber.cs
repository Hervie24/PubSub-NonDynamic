using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub
{
	public class Subscriber
	{
		public Subscriber()
		{

		}

		public List<string> topics = new List<string>();
		public Queue<Message> myMessage = new Queue<Message>();

		public void Listen(string topic)
		{
			topics.Add(topic);
		}
		public void Listen(string newTopic, int index)
		{
			topics[index] = newTopic;

		}

		public void Print()
		{

			foreach (var topic in topics)
			{
				
				Message messageTobeSend = myMessage.Dequeue();
				Console.WriteLine("Topic: " + messageTobeSend.topic + "\n" + "Topic description:" + messageTobeSend.topicDescription);
			}

			//foreach (var subscriberTopic in subscriberTopics)
			//{
			//	StringBuilder sb = new StringBuilder();
			//	Message newMessage = myMessage.Dequeue();
			//	foreach (var topic in subscriberTopic.Value)
			//	{
			//		sb.AppendLine(topic);
			//	}


			//		Console.WriteLine("Topic: " + newMessage.topic + "\n" + newMessage.topicDescription);

			//}
		}
	}
}
