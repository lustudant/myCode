namespace GameEngine
{
	public class Transform : Component
	{		
		public Vector2 position
		{
			get; set;
		}
		public void Translate(Vector2 translate)
		{
			Vector2 next = position;
			next.x = position.x + translate.x;
			next.y = position.y + translate.y;

			if (IsAccessible(next))
			{
				GameObject.RemoveAtPoint(position);
				GameObject.InsertAtPoint(next, gameObject);
				position = next;
			}
		}
		private bool IsAccessible(Vector2 point)
		{
			if (GameObject.Exists(point)) return false;
			return true;
		}
	}
}
