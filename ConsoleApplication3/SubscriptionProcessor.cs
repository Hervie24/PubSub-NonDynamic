using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub
{
	public class SubscriptionProcessor
	{
		private FakeServer _myFakeServer;
		public SubscriptionProcessor(FakeServer server)
		{
			_myFakeServer = server;
		}

		public SubscriptionProcessor()
		{

		}



		public void ProcessSubscription(List<SubscriberInfo> subscriberInfoList)
		{
			Publisher publish = new Publisher();
			FakeServer server = new FakeServer();

			var mySubscriber = new Subscriber();
			var listOfTopics = new List<string>();

			TopicsContent customContent = new TopicsContent();
			publish.Send(customContent.AnimalTopics(), server);
			publish.Send(customContent.RobotTopics(), server);

			

			foreach (var subscriberinfo in subscriberInfoList)
			{
				foreach (var topic in subscriberinfo.topictype)
				{
					if (topic.isAnimal)
					{
						mySubscriber.Listen("Animals");
					}
					if (topic.isRobot)
					{
						mySubscriber.Listen("Robot");
					}
					server.subscribers.Add(mySubscriber);

					//mySubscriber.Listener(new KeyValuePair<string, List<string>>(subscriberinfo.name, listOfTopics));
				}

			}
			server.Forward();
			mySubscriber.Print();

		}
	}
}
