using System;
using System.Text;

namespace GameEngine
{
	public class Camera
	{
		private static Camera camera;		
		int width, height;
		StringBuilder builder = new StringBuilder();

		public static Camera main
		{
			get
			{
				if (camera == null)
				{
					camera = new Camera();
				}
				return camera;
			}
		}
		public Camera()
		{
			width = 20;
			height = 20;
		}
		
		private string buffer;

		public void Render()
		{
			WriteLine("AUTOR : LUIS FERNANDO GOMES SOARES");
			WriteLine("");
			WriteLine(" INSTRUÇÕES DE JOGAR");
			WriteLine("[UP]	MOVE PARA CIMA");
			WriteLine("[DOWN]	MOVE PARA BAIXO");
			WriteLine("[LEFT]	MOVE PARA ESQUERDO");
			WriteLine("[RIGHT]	MOVE PARA DIREITO");
			WriteLine("");

			for (int y = 0; y < height; y = y + 1)
				{
					for (int x = 0; x < width; x = x + 1)
					{
						Vector2 p = new Vector2(x, y);

						if (GameObject.Exists(p))
						{
							GameObject o = GameObject.Find(p);
							Renderer render = o.renderer;
							if (render != null)
							{
								buffer += render.rend;
							}
							else
							{
								buffer += ' ';
							}
						}
						else
						{
							buffer += ' ';
						}
					}
					WriteLine(buffer);
					buffer = "";
			}
			Console.Clear();
			Console.Write(builder);
			builder.Clear();
		}
		private void WriteLine(string buffer)
		{
			builder.AppendLine(buffer);
		}
	}
}
