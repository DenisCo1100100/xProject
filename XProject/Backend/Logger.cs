using System;
using System.Diagnostics;

namespace Backend
{
	public static class Logger
	{
		public static void Debug(string message, Type type)
		{
			Trace.WriteLine($"{DateTime.Now}|DEBUG|{type.Name}|{message}");
		}

		public static void Info(string message, Type type)
		{
			Trace.WriteLine($"{DateTime.Now}|INFO|{type.Name}|{message}");
		}

		public static void Warn(string message, Type type)
		{
			Trace.WriteLine($"{DateTime.Now}|WARN|{type.Name}|{message}");
		}

		public static void Error(string message, Type type)
		{
			Trace.WriteLine($"{DateTime.Now}|ERROR|{type.Name}|{message}");
		}

		public static void Fatal(string message, Type type)
		{
			Trace.WriteLine($"{DateTime.Now}|FATAL|{type.Name}|{message}");
		}
	}
}