// Chris Cascioli
// 1/24/24
// Demo of custom delegates and events

namespace DelegateEventDemo
{
	/// <summary>
	/// Represents any method that takes a string and an integer
	/// </summary>
	/// <param name="message">A message to report</param>
	/// <param name="health">Remaining health</param>
	delegate void LowHealthDelegate(string message, int health);


	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a tank object and make it take damage
			Tank t = new Tank();

			// Once the object is made, we can subscribe to its LowHealth event
			t.LowHealth += LowHealthCallback;

			// Damage the tank
			t.TakeDamage(3);
			t.TakeDamage(20);
			t.TakeDamage(7);
			t.TakeDamage(10);
			t.TakeDamage(30);
			t.TakeDamage(17);
		}

		/// <summary>
		/// Prints a teammate's message and remaning health
		/// </summary>
		/// <param name="message">Teammate's message</param>
		/// <param name="health">Remaining health</param>
		static void LowHealthCallback(string message, int health)
		{
			Console.WriteLine($"Teammate yells '{message}'. {health} health remaining.");
		}

		static void awefiuwef(string m, int h)
		{
			Console.WriteLine("awefwaefawef");
		}
	}
}