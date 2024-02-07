using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGameDemo
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;

		// The image we're loading
		private Texture2D marioImage;
		private Rectangle marioRect;

		public Game1()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;

			// Resizing the window
			_graphics.PreferredBackBufferWidth = 1920;
			_graphics.PreferredBackBufferHeight = 1080;
			_graphics.ApplyChanges();

		}

		protected override void Initialize()
		{
			marioRect = new Rectangle(50, 50, 300, 200);

			base.Initialize();
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch(GraphicsDevice);

			// Load any and all assets (content) here
			// Note: No try/catch necessary
			marioImage = this.Content.Load<Texture2D>("mario");
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			marioRect.X += 10;

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			// Drawing anything requires 3 steps:

			// Step 1: Begin the sprite batch
			_spriteBatch.Begin();

			// Step 2: Draw() any and all images
			_spriteBatch.Draw(
				marioImage,		// Image to draw
				new Vector2(0, 0), // Where to draw
				Color.White);   // White means no tint!

			_spriteBatch.Draw(
				marioImage,
				marioRect,
				Color.White);

			// Step 3: End the sprite batch (here is where drawing happens)
			_spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}