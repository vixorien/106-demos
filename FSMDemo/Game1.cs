using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FSMDemo
{
	/// <summary>
	/// Possible states for my game
	/// </summary>
	enum GameState
	{
		Menu,
		Options,
		Gameplay,
		Pause
	}

	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;

		private SpriteFont font;

		// State management
		private GameState currentState;

		public Game1()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			// Our initial state
			currentState = GameState.Menu;

			base.Initialize();
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch(GraphicsDevice);

			font = Content.Load<SpriteFont>("Font");
		}

		protected override void Update(GameTime gameTime)
		{
			
			// Check the current state to know what to do!
			KeyboardState kb = Keyboard.GetState();

			switch (currentState)
			{
				case GameState.Menu:

					// Check ONLY for transitions FROM menu
					if (kb.IsKeyDown(Keys.O)) currentState = GameState.Options;
					if (kb.IsKeyDown(Keys.Space)) currentState = GameState.Gameplay;

					break;

				case GameState.Options:

					// Check for transitions
					if (kb.IsKeyDown(Keys.Escape)) currentState = GameState.Menu;

					break;

				case GameState.Gameplay:

					// Check for transitions
					if (kb.IsKeyDown(Keys.P)) currentState = GameState.Pause;

					break;

				case GameState.Pause:
					
					// Check ONLY for transitions FROM Pause
					if (kb.IsKeyDown(Keys.M)) currentState = GameState.Menu;
					if (kb.IsKeyDown(Keys.Escape)) currentState = GameState.Gameplay;

					break;
			}

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.Black);

			_spriteBatch.Begin();

			// Check the state to know what to draw!
			switch (currentState)
			{
				case GameState.Menu:
					string menuText = "Main Menu\n\n";
					menuText += " Press O for Options\n";
					menuText += " Press Space to play";

					_spriteBatch.DrawString(font, menuText, new Vector2(50, 50), Color.White);
					break;

				case GameState.Options:
					string optionsText = "Options\n\n";
					optionsText += " Press Esc for Main Menu\n";

					_spriteBatch.DrawString(font, optionsText, new Vector2(50, 50), Color.White);

					break;

				case GameState.Gameplay:
					string gameText = "This is the Game!\n\n";
					gameText += " Press P to Pause\n";

					_spriteBatch.DrawString(font, gameText, new Vector2(50, 50), Color.White);


					break;

				case GameState.Pause:
					string pauseText = "Paused\n\n";
					pauseText += " Press Esc to Resume\n";
					pauseText += " Press M for Main Menu";

					_spriteBatch.DrawString(font, pauseText, new Vector2(50, 50), Color.White);


					break;
			}


			_spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}