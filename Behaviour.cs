namespace GameEngine
{
	public class Behaviour : Component
	{
		public Behaviour()
		{
			
		}

		public virtual void Start() { }
		public virtual void Update() { }
		public virtual void OnCollision(GameObject other) { }

		private bool started = true;

		public override void Active()
		{
			if (started == true)
			{
				Start();
				started = false;
			}
			Update();
		}		
	}
}
