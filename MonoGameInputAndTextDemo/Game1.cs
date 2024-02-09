using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGameInputAndTextDemo
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;

		// Luigi data
		private Texture2D luigiTexture;
		private Rectangle luigiRect;
		private Vector2 luigiSpeed;

		private Rectangle tinyLuigiRect;

		// Input data
		private KeyboardState prevKB;

		// Font data
		private SpriteFont fontVerdana18;

		public Game1()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			_graphics.PreferredBackBufferWidth = 1000;
			_graphics.PreferredBackBufferHeight = 800;
			_graphics.ApplyChanges();

			base.Initialize();
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch(GraphicsDevice);

			luigiTexture = Content.Load<Texture2D>("luigi");
			luigiRect = new Rectangle(0, 0, luigiTexture.Width, luigiTexture.Height);
			luigiSpeed = new Vector2(3, 4);

			tinyLuigiRect = new Rectangle(30, 30, luigiRect.Width / 3, luigiRect.Height / 3);

			fontVerdana18 = Content.Load<SpriteFont>("Verdana18");
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();


			// Bounce
			luigiRect.X += (int)luigiSpeed.X;
			luigiRect.Y += (int)luigiSpeed.Y;

			// Check the bottom
			if (luigiRect.Y + luigiRect.Height > _graphics.PreferredBackBufferHeight ||
				luigiRect.Y < 0)
			{
				luigiSpeed.Y *= -1;
			}

			if (luigiRect.X + luigiRect.Width > _graphics.PreferredBackBufferWidth ||
				luigiRect.X < 0)
			{
				luigiSpeed.X *= -1;
			}

			// Move tiny luigi
			KeyboardState kb = Keyboard.GetState();

			if (kb.IsKeyDown(Keys.W))
			{
				tinyLuigiRect.Y -= 10;
			}
			
			if (kb.IsKeyDown(Keys.S))
			{
				tinyLuigiRect.Y += 10;
			}

			if (kb.IsKeyDown(Keys.D))
			{
				tinyLuigiRect.X += 10;
			}

			if (kb.IsKeyDown(Keys.A))
			{
				tinyLuigiRect.X -= 10;
			}

			// If the space bar is pressed, get
			// a little bigger
			if (kb.IsKeyDown(Keys.Space) && prevKB.IsKeyUp(Keys.Space))
			{
				tinyLuigiRect.Width += 5;
				tinyLuigiRect.Height += 5;
			}


			// At the VERY end of Update, store this frame's
			// keyboard state for NEXT frame
			prevKB = kb;

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			_spriteBatch.Begin();

			// Draw luigi
			_spriteBatch.Draw(luigiTexture, luigiRect, Color.White);

			_spriteBatch.Draw(luigiTexture, tinyLuigiRect, Color.White);

			// Draw some example text (with a drop shadow)
			_spriteBatch.DrawString(fontVerdana18, "Hello, World!", new Vector2(12, 12), Color.Black);
			_spriteBatch.DrawString(fontVerdana18, "Hello, World!", new Vector2(10, 10), Color.White);


			_spriteBatch.DrawString(
				fontVerdana18,
				$"Luigi Pos: [{luigiRect.X}, {luigiRect.Y}]",
				new Vector2(10, 120),
				Color.White);


			_spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}