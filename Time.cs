namespace GameEngine
{
	public static class Time
	{
		static int s_milisecond;
		public static float time = 0;
	
		public static int Sleep(int second)
		{
			int millisecond = System.DateTime.Now.Millisecond;
			if (s_milisecond != millisecond)
			{
				s_milisecond = millisecond;
				time = time + 1;
			}
			if (time >= second)
			{
				time = 0;
				return 1;
			}
			return 0;
		}
	}
}
