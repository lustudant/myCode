using GameEngine;

namespace GameApplication
{
	public class Game
	{
		public static void Build(Vector2 position, char rend)
		{
			new GameObject(position).AddComponent<Renderer>().rend = rend;
		}
		public static void Main(string[] args)
		{
			char rend = '+';

			Build(new Vector2(0, 0), rend);
			Build(new Vector2(2, 0), rend);
			Build(new Vector2(3, 0), rend);
			Build(new Vector2(4, 0), rend);
			Build(new Vector2(5, 0), rend);
			Build(new Vector2(6, 0), rend);
			Build(new Vector2(7, 0), rend);
			Build(new Vector2(8, 0), rend);

			Build(new Vector2(0, 1), rend);
			Build(new Vector2(4, 1), rend);
			Build(new Vector2(8, 1), rend);

			Build(new Vector2(0, 2), rend);
			Build(new Vector2(1, 2), rend);
			Build(new Vector2(2, 2), rend);
			Build(new Vector2(4, 2), rend);
			Build(new Vector2(6, 2), rend);
			Build(new Vector2(8, 2), rend);

			Build(new Vector2(0, 3), rend);
			Build(new Vector2(4, 3), rend);
			Build(new Vector2(6, 3), rend);
			Build(new Vector2(8, 3), rend);

			Build(new Vector2(0, 4), rend);
			Build(new Vector2(2, 4), rend);
			Build(new Vector2(3, 4), rend);
			Build(new Vector2(4, 4), rend);
			Build(new Vector2(6, 4), rend);
			Build(new Vector2(8, 4), rend);

			Build(new Vector2(0, 5), rend);
			Build(new Vector2(6, 5), rend);
			Build(new Vector2(8, 5), rend);

			Build(new Vector2(0, 6), rend);
			Build(new Vector2(1, 6), rend);
			Build(new Vector2(2, 6), rend);
			Build(new Vector2(3, 6), rend);
			Build(new Vector2(4, 6), rend);
			Build(new Vector2(5, 6), rend);
			Build(new Vector2(6, 6), rend);
			Build(new Vector2(8, 6), rend);

			GameObject myObject = new GameObject(new Vector2(1,0));
			myObject.AddComponent<MyBehaviour>();
			myObject.AddComponent<Renderer>().rend = 'o';

			Application.Play();
		}
	}
}
