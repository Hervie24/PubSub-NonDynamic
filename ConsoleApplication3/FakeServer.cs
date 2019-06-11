using PubSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub
{
	public class FakeServer
	{
		private static int _subscribers = 0;
		public FakeServer()
		{

		}
		public FakeServer(int subscribers)
		{
			_subscribers = subscribers;
		}

		public Queue<Message> buffer = new Queue<Message>();
		public List<Subscriber> subscribers = new List<Subscriber>();

		public void Forward()
		{
			while (buffer.Count != 0)
			{
				Message tempMessage = buffer.Dequeue();
				foreach (var subscriber in subscribers)
				{
					foreach (var topic in subscriber.topics)
					{
						if (tempMessage.topic == topic)
						{
							subscriber.myMessage.Enqueue(tempMessage);
						}
					}

				}

			}
		}
	}
}

