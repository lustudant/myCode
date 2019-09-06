using GameEngine;

namespace GameApplication
{
	public class MyBehaviour : Behaviour
	{
		public override void Start()
		{
			
		}
		public override void Update()
		{
			if (Input.GetKey(System.ConsoleKey.DownArrow))
			{
				gameObject.transform.Translate(Vector2.down);
			}
			if (Input.GetKey(System.ConsoleKey.UpArrow))
			{
				gameObject.transform.Translate(Vector2.up);
			}
			if (Input.GetKey(System.ConsoleKey.LeftArrow))
			{
				gameObject.transform.Translate(Vector2.left);
			}
			if (Input.GetKey(System.ConsoleKey.RightArrow))
			{
				gameObject.transform.Translate(Vector2.right);
			}
		}
	}
}
