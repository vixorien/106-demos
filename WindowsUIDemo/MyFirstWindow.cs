// Chris Cascioli
// 1/26/24
// The class that represents a interactable window

namespace WindowsUIDemo
{
	internal class MyFirstWindow : Form
	{
		/// <summary>
		/// Create and set up the window
		/// </summary>
		public MyFirstWindow()
		{
			this.Text = "I am a window!";
			this.Size = new Size(400, 600);

			// Create a button we can click
			Button button = new Button();
			button.Text = "Click me!";
			button.Size = new Size(200, 100);
			button.Location = new Point(50, 50);

			button.Click += Button_Click;

			// Add the button to the form
			this.Controls.Add(button);
		}

		public void Button_Click(object? sender, EventArgs e)
		{
			// Change the color of the button
			// First, downcast to Button
			Button b = (Button)sender!;

			// Copy/alter/replace
			Point loc = b.Location;
			loc.X += 50;
			b.Location = loc;

			// Change the color
			Random rng = new Random();
			b.BackColor = Color.FromArgb(
				rng.Next(256),
				rng.Next(256),
				rng.Next(256));
		}
	}
}
