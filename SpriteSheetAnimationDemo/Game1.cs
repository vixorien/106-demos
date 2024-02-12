using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpriteSheetAnimationDemo
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;

		// Mario texture stuff
		private Texture2D marioTexture;
		private Vector2 marioPosition;
		private int numSpritesInSheet;
		private int widthOfSingleSprite;

		// Animation data
		private int currentFrame;
		private double framesPerSecond;
		private double secondsPerFrame;
		private double timeCounter;

		public Game1()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			// TODO: Add your initialization logic here

			base.Initialize();
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch(GraphicsDevice);

			// Handle mario texture stuff
			marioTexture = Content.Load<Texture2D>("MarioSpriteSheet");
			numSpritesInSheet = 4;
			widthOfSingleSprite = marioTexture.Width / numSpritesInSheet;

			marioPosition = new Vector2(200, 200);

			// Animation setup
			currentFrame = 1;
			framesPerSecond = 20.0;
			secondsPerFrame = 1.0 / framesPerSecond;
			timeCounter = 0;
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			// TODO: Add your update logic here
			UpdateAnimation(gameTime);

			base.Update(gameTime);
		}

		/// <summary>
		/// Helper for handling animation updates
		/// </summary>
		/// <param name="gt">Time info</param>
		private void UpdateAnimation(GameTime gt)
		{
			// How much time has passed since last frame?
			timeCounter += gt.ElapsedGameTime.TotalSeconds;
			if (timeCounter >= secondsPerFrame)
			{
				currentFrame++;
				if (currentFrame >= 4)
					currentFrame = 1; // Since frame zero is "standing"

				timeCounter -= secondsPerFrame;
			}
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.Black);

			_spriteBatch.Begin();
			_spriteBatch.Draw(
				marioTexture, 
				marioPosition, 
				new Rectangle(currentFrame * widthOfSingleSprite, 0, widthOfSingleSprite, marioTexture.Height), 
				Color.White);
			_spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}