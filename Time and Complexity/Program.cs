using System;

namespace Time_and_Complexity
{
    class Program
    {
        static void Main(string[] args)
        {
			int numberOfInputs = Convert.ToInt32(Console.ReadLine());
			int i, j, input;
			string output;
			for (i = 1; i <= numberOfInputs; i++)
			{
				input = Convert.ToInt32(Console.ReadLine());
				for (j = 2; j <= input / j; j++)
				{
					if (input % j == 0)
						input = 1;
				}
				output = input == 1 ? "Not prime" : "Prime";
				Console.WriteLine(output);

				// comment added 
			}

		}
    }
}
