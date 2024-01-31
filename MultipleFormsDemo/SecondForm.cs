// Chris Cascioli
// 1/31/24
// A second, custom form in the same program

namespace MultipleFormsDemo
{
	public partial class SecondForm : Form
	{
		// A reference to the other window
		private Form1 firstForm;

		public SecondForm(Form1 firstForm)
		{
			// Save the reference
			this.firstForm = firstForm;

			InitializeComponent();
		}

		/// <summary>
		/// This event is fired off when the form is ABOUT to close
		/// giving us a chance to stop that!
		/// </summary>
		private void SecondForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Prevent the actual close!
			e.Cancel = true;

			// Hide this window instead
			this.Hide();
		}

		/// <summary>
		/// Changes the color of the original form
		/// </summary>
		private void buttonChange_Click(object sender, EventArgs e)
		{
			firstForm.BackColor = Color.Tomato;
		}
	}
}
