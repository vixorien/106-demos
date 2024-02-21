// Chris Cascioli
// 2/21/24
// Example of the Singleton design pattern

namespace SingletonDemo
{
	internal class ExampleSingleton
	{
		// The problem we're trying to solve:
		//  - Globally accessible object
		//  - Only one can EVER be instantiated

		/// <summary>
		/// The one and only instance of this class
		/// </summary>
		private static ExampleSingleton instance = null!;

		/// <summary>
		/// Gets the one and only instance
		/// </summary>
		public static ExampleSingleton Instance
		{
			get
			{
				// If it doesn't exist, make it!
				if (instance == null)
					instance = new ExampleSingleton();

				// Otherwise, just give back the one and only
				return instance;
			}
		}

		// Initialization logic
		private bool initialized = false;

		// Standard fields
		private int numberOfThings;
		private string name;

		public int NumberOfThings { get { return numberOfThings; } }

		public string Name { get { return name; } }

		/// <summary>
		/// Creates a barebones object.  The point
		/// is that the constructor is PRIVATE
		/// </summary>
		private ExampleSingleton()
		{

		}

		/// <summary>
		/// The public Initialize function is essentially how we
		/// get the object "ready", kind of like a constructor
		/// </summary>
		/// <param name="name">Name of thing</param>
		/// <param name="numThings">Number of them</param>
		public void Initialize(string name, int numThings)
		{
			if (initialized)
				throw new InvalidOperationException("Singleton already initialized");

			this.name = name;
			this.numberOfThings = numThings;
			initialized = true;
		}

	}
}
