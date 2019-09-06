using System;
namespace GameEngine
{
	public static class Input
	{
		private static ConsoleKey s_key;

		public static void Process()
		{
			if (Console.KeyAvailable)
			{
				s_key = Console.ReadKey().Key;
			}
		}
		public static bool GetKey (ConsoleKey key)
		{
			if (key == s_key)
			{
				s_key = ConsoleKey.Clear;
				return true;
			}
			return false;
		}		
	}
}
