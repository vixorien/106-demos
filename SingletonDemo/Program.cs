namespace SingletonDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Can we make a new singleton object?  NO!  On purpose!
			//ExampleSingleton single = new ExampleSingleton();

			// Grab the STATIC reference to get the actual object
			ExampleSingleton.Instance.Initialize("Bobby", 6);

			ExampleSingleton theOne = ExampleSingleton.Instance;

			// Get any of the data
			Console.WriteLine("Singleton name: " + theOne.Name);
			Console.WriteLine("Singleton num: " + theOne.NumberOfThings);


		}
	}
}