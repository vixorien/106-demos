// Chris Cascioli
// 1/29/24
// Demo of basic windows forms and events

namespace WindowsFormsDemo
{
	public partial class Form1 : Form
	{
		// Fields
		private int count;

		public Form1()
		{
			InitializeComponent();

			// Set up our fields
			count = 0;
			textCount.Text = count.ToString();

			timerCount.Start();
		}

		/// <summary>
		/// Add to the count and redisplay
		/// </summary>
		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			count++;
			progressBar1.Increment(1);
			textCount.Text = count.ToString();
		}

		/// <summary>
		/// Decrement the count and redisplay
		/// </summary>
		private void buttonSubtract_Click(object sender, EventArgs e)
		{
			count--;
			progressBar1.Increment(-1);
			textCount.Text = count.ToString();
		}

		/// <summary>
		/// Resets the count and redisplays
		/// </summary>
		private void buttonReset_Click(object sender, EventArgs e)
		{
			count = 0;
			progressBar1.Value = progressBar1.Minimum;
			textCount.Text = count.ToString();
		}

		/// <summary>
		/// Adds and redisplays every so many milliseconds
		/// </summary>
		private void timerCount_Tick(object sender, EventArgs e)
		{
			count++;
			progressBar1.Increment(1);
			textCount.Text = count.ToString();
		}
	}
}