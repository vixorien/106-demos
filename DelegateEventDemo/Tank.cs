// Chris Cascioli
// 1/24/24
// Represents a player in a game that can take a lot of damage

namespace DelegateEventDemo
{
	internal class Tank
	{
		/// <summary>
		/// An event that occurs when the tank is at or below 20 health
		/// </summary>
		public event LowHealthDelegate LowHealth;

		private int health;

		/// <summary>
		/// Creates a new tank player with 100 health
		/// </summary>
		public Tank()
		{
			health = 100;
		}

		/// <summary>
		/// Damages the player
		/// </summary>
		/// <param name="amount">Amount of incoming damage</param>
		public void TakeDamage(int amount)
		{
			health -= amount;

			// Detect that we're low on health
			if (health <= 20 && LowHealth != null)
			{
				// Let other objects or code know!
				LowHealth("I'm dyin' over here!", health);
			}
		}
	}
}
