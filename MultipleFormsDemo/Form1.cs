// Chris Cascioli
// 1/31/24
// Demo of multiple forms including message boxes

namespace MultipleFormsDemo
{
	public partial class Form1 : Form
	{
		// The other window we'll eventually show
		private SecondForm form2;

		public Form1()
		{
			InitializeComponent();

			// Create, but do NOT show, the second form
			form2 = new SecondForm(this);
		}

		/// <summary>
		/// Show the user a pre-made message box
		/// </summary>
		private void buttonMessageBox_Click(object sender, EventArgs e)
		{
			// This is a "blocking" function, meaning the
			// code does not proceed until it is dealt with
			MessageBox.Show("Hey, you, listen!");

			// Create a message box that accepts
			// multiple types of input
			DialogResult answer = MessageBox.Show(
				"I am the text.  Do you agree?",
				"This is the title bar",
				MessageBoxButtons.YesNoCancel,
				MessageBoxIcon.Question);

			// Check the user's answer
			if (answer == DialogResult.Yes)
			{
				MessageBox.Show("YES!");
			}
			else if (answer == DialogResult.No)
			{
				MessageBox.Show("NO!");
			}
			else if (answer == DialogResult.Cancel)
			{
				MessageBox.Show("CANCEL!");
			}
		}

		/// <summary>
		/// Quick example of a Save File Dialog (which was
		/// added to the form through the toolbox)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSave_Click(object sender, EventArgs e)
		{
			// This is a pre-made component on the form
			DialogResult result = saveFileDialog1.ShowDialog();

			MessageBox.Show("Result was " + result);
		}

		/// <summary>
		/// Shows the existing second custom window
		/// </summary>
		private void buttonSecondForm_Click(object sender, EventArgs e)
		{
			// After creating the form, we have to SHOW it
			// Either .Show() for an independent window
			// Or .ShowDialog() for a one-at-a-time window
			form2.Show();
			
		}
	}
}