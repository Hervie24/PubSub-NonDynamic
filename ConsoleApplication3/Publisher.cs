﻿using PubSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub
{
	public class Publisher
	{
		public Publisher()
		{

		}

		public void Send(Message newMessage, FakeServer myServer)
		{
			myServer.buffer.Enqueue(newMessage);
		}

	};
}
