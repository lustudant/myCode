namespace GameEngine
{
	public static class Application
	{
		public delegate void OnActive();
		public static event OnActive onActived;

		private static void Process()
		{
			if (onActived != null)
			{
				onActived();
			}
		}
		public static void Play()
		{
			while (true)
			{
				Input.Process();
				Process();				
				int current = Time.Sleep(120);
				if (current == 1)
				{
					Camera.main.Render();
				}
			}
		}
	}
}
