using PubSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
	class MainProgram
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine("Predefine topics: Animals, Robots");
			

			Console.WriteLine("Enter number of subscriber:");
			var subscriber = Int16.Parse(Console.ReadLine());

			List<SubscriberInfo> subscriberInfoList = new List<SubscriberInfo>();


			for (var i = 1; i <= subscriber; i++)
			{
				Console.WriteLine($"Enter subscriber number {i} name:");
				var name = Console.ReadLine();
				Console.WriteLine("Do you want to subscribe for animal topic? [Y/N]");
				var animalraw = Console.ReadLine().Trim().ToLowerInvariant();
				var animalT = animalraw == "y" ? true : false;
				Console.WriteLine("Do you want to subscribe for robot topic? [Y/N]");
				var robotraw = Console.ReadLine().Trim().ToLowerInvariant();
				var robotT = robotraw == "y" ? true : false;
				subscriberInfoList.Add(new SubscriberInfo
				{
					name = name,
					topictype = new List<topicTypes>()
						{
							new topicTypes { isAnimal = animalT, isRobot =robotT }
						}
				});
			}

			SubscriptionProcessor process = new SubscriptionProcessor();
				process.ProcessSubscription(subscriberInfoList);


		}
	}
}
