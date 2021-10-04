using Grpc.Core;

namespace Backend
{
	public static class ConnectionHandler
	{
		private const int PORT = 50051;
		private const string IPV4 = "25.91.212.207";
		private static string _clientAddress = $"{IPV4}:{PORT}";

		public static Channel Channel { get; private set; }

		public static void Connection()
		{
			Channel = new Channel(_clientAddress, ChannelCredentials.Insecure);
		}

		public static void Disconтection()
		{
			Channel.ShutdownAsync().Wait();
		}
	}
}