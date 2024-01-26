// Chris Cascioli
// 1/26/24
// Demo of windows forms

namespace WindowsUIDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Enable modern visual styles
			Application.EnableVisualStyles();

			// Run the app with our new window as the main form
			Application.Run(new MyFirstWindow());
		}
	}
}