using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.IO;

namespace GravityAndCollisionsPE
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;

		private Texture2D playerTexture;
		private Texture2D obstacleTexture;

		private float playerSpeedX;
		private Vector2 playerVelocity;
		private Vector2 jumpVelocity;
		private Vector2 playerPosition;
		private Vector2 gravity;

		private List<Rectangle> obstacleRects;
		private KeyboardState prevKB;

		public Game1()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}


		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// </summary>
		protected override void Initialize()
		{
			playerPosition = new Vector2(400, 100);
			playerVelocity = Vector2.Zero;
			jumpVelocity = new Vector2(0, -15.0f);
			gravity = new Vector2(0, 0.5f);

			playerSpeedX = 5.0f;

			obstacleRects = new List<Rectangle>();

			base.Initialize();
		}


		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch(GraphicsDevice);

			playerTexture = Content.Load<Texture2D>("mario");
			obstacleTexture = Content.Load<Texture2D>("pixel");

			// Manually load the obstacles
			LoadObstaclesFromFile("Content/obstacles.txt");
		}

		/// <summary>
		/// Loads obstacle rectangles from the given file
		/// </summary>
		/// <param name="file">Path to the file containing obstacles</param>
		private void LoadObstaclesFromFile(string file)
		{
			// Provide an error message in Visual Studio's output window
			// as a reminder to students
			if (!File.Exists(file))
			{
				System.Diagnostics.Debug.WriteLine($"Error: Cannot find file '{file}' in the output directory!");
				System.Diagnostics.Debug.WriteLine($"       Did you remember to add the file to the MGCB Editor AND set its Build Action to 'Copy'?");
				return;
			}

			// Open the file for reading
			StreamReader reader = new StreamReader(file);

			// Read all of the lines, parsing each as we go
			string line = null;
			while ((line = reader.ReadLine()) != null)
			{
				// Ignore blank lines and comments
				if (line.Length == 0 || line.StartsWith("//"))
					continue;

				// Split into 4 ints and parse into a rectangle
				string[] obstacleDetails = line.Split(',');
				obstacleRects.Add(new Rectangle(
					int.Parse(obstacleDetails[0]),
					int.Parse(obstacleDetails[1]),
					int.Parse(obstacleDetails[2]),
					int.Parse(obstacleDetails[3])));
			}

			// All done with the file
			reader.Close();
		}


		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, etc.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			// Handle input, apply gravity and then deal with collisions
			ProcessInput();
			ApplyGravity();
			ResolveCollisions();

			// Save the old state at the end of the frame
			prevKB = Keyboard.GetState();
			base.Update(gameTime);
		}

		/// <summary>
		/// Handles movement for sidescrolling game with gravity
		/// </summary>
		private void ProcessInput()
		{
			// Grab keyboard info
			KeyboardState kb = Keyboard.GetState();

			// Handle horizontal movement
			float xMove = 0;
			if (kb.IsKeyDown(Keys.A)) xMove -= playerSpeedX;
			if (kb.IsKeyDown(Keys.D)) xMove += playerSpeedX;

			playerPosition.X += xMove;

			// Handle jumping
			if (SingleKeyPress(Keys.Space))
				playerVelocity.Y = jumpVelocity.Y;
		}

		/// <summary>
		/// Applies gravity to the player
		/// </summary>
		private void ApplyGravity()
		{
			playerVelocity += gravity;
			playerPosition += playerVelocity;
		}

		/// <summary>
		/// Handles player collisions with obstacles
		/// </summary>
		private void ResolveCollisions()
		{
			// Get the player's current rect
			Rectangle playerRect = GetPlayerRect();

			// Gather all intersections
			List<Rectangle> intersections = new List<Rectangle>();
			foreach (Rectangle obstacle in obstacleRects)
			{
				if (playerRect.Intersects(obstacle))
					intersections.Add(obstacle);
			}

			// Resolve horizontal collisions first
			for(int i = 0; i < intersections.Count; i++)
			{
				// Get some info about the intersection
				Rectangle overlap = Rectangle.Intersect(playerRect, intersections[i]);
				int xDiff = Math.Sign(intersections[i].X - playerRect.X);
				int yDiff = Math.Sign(intersections[i].Y - playerRect.Y);

				// X is smaller axis (or equal)
				if (overlap.Width <= overlap.Height)
				{
					// Push based on difference between rects
					int push = -xDiff * overlap.Width;

					// Actually push
					playerRect.X += push;
				}
			}

			// Resolve vertical collisions
			for (int i = 0; i < intersections.Count; i++)
			{
				// Get some info about the intersection
				Rectangle overlap = Rectangle.Intersect(playerRect, intersections[i]);
				int xDiff = Math.Sign(intersections[i].X - playerRect.X);
				int yDiff = Math.Sign(intersections[i].Y - playerRect.Y);

				// Y is smaller axis
				if (overlap.Height < overlap.Width)
				{
					// Push based on difference between rects
					int push = -yDiff * overlap.Height;

					// Actually push
					playerRect.Y += push;

					// Stop vertical movement
					playerVelocity.Y = 0.0f;
				}

			}

			// Save position from our temp rectangle
			playerPosition.X = playerRect.X;
			playerPosition.Y = playerRect.Y;
		}

		/// <summary>
		/// Determines if a key was initially pressed this frame
		/// </summary>
		/// <param name="key">The key to check</param>
		/// <returns>True if this is the first frame the key is pressed, false otherwise</returns>
		private bool SingleKeyPress(Keys key)
		{
			return Keyboard.GetState().IsKeyDown(key) && prevKB.IsKeyUp(key);
		}


		/// <summary>
		/// Gets a rectangle for the player based on the player's
		/// current position (a vector of float values)
		/// </summary>
		/// <returns>A rectangle representing the bounds of the player</returns>
		private Rectangle GetPlayerRect()
		{
			return new Rectangle(
				(int)playerPosition.X,
				(int)playerPosition.Y,
				playerTexture.Width,
				playerTexture.Height);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.Black);

			_spriteBatch.Begin();

			// Draw the player using a rectangle make from their position
			_spriteBatch.Draw(playerTexture, GetPlayerRect(), Color.White);

			// Draw each obstactle
			foreach (Rectangle rect in obstacleRects)
			{
				_spriteBatch.Draw(obstacleTexture, rect, Color.SeaGreen);
			}

			_spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}