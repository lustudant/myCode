using System.Collections.Generic;

namespace GameEngine
{
	public class GameObject
	{
		private static Dictionary<Vector2, GameObject> world = new Dictionary<Vector2, GameObject>();
				
		public static GameObject Find(Vector2 point)
		{
			return world[point];
		}
		public static bool Exists(Vector2 point)
		{
			return world.ContainsKey(point);
		}
		public static void InsertAtPoint(Vector2 point, GameObject o)
		{
			world.Add(point,o);
		}
		public static void RemoveAtPoint(Vector2 point)
		{			
			world.Remove(point);	
		}
		private Transform s_transform;
		public Transform transform
		{
			get { return s_transform; }
		}
		private Renderer s_renderer;
		public Renderer renderer
		{
			get { return s_renderer; }
		}
		private Behaviour s_behaviour;
		public Behaviour behaviour
		{
			get { return s_behaviour; }
		}

		public GameObject(Vector2 position)
		{
			Transform transform = new Transform();
			transform.gameObject = this;
			transform.position = position;
			s_transform = transform;
			world[position] = this;
			Application.onActived += Active;
		}
		private void Create()
		{

		}
		private void Active()
		{
			if (s_behaviour != null)
			{
				s_behaviour.Active();
			}
		}
		public T AddComponent<T>() where T : new() 
		{
			T t = new T();
						
			if (t is Renderer)
			{
				s_renderer = t as Renderer;
				s_renderer.gameObject = this;
			}
			if (t is Behaviour)
			{
				s_behaviour = t as Behaviour;
				s_behaviour.gameObject = this;
			}
			return t;
		}
	}
}
