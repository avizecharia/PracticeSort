using System.Collections.Generic;

namespace PracticeSort
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int[] numbers = { 1, 2,9,4,5,7,4};
			// bubble sort
			for (int i = 0; i < numbers.Length; i++)
			{
				bool done = true;
				for (int j = 0 ; j < numbers.Length - 1; j++)
				{
					if (numbers[j] > numbers[j + 1])
					{
						(numbers[j + 1], numbers[j]) =
							(numbers[j], numbers[j + 1]);
						done = false;
					}
				}
				if (done)
				{
					break;
				}
			}
			Console.WriteLine(string.Join(",", numbers));

			// selcaation sort
			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	int minIndex = i;
			//	for (int j = i + 1; j < numbers.Length; j++)
			//	{
			//		if (numbers[j] < numbers[minIndex])
			//		{
			//			int temp = numbers[j];
			//			numbers[j] = numbers[minIndex];
			//			numbers[minIndex] = temp;
			//			minIndex = j;
			//		}
			//	}
			//}
			//Console.WriteLine(string.Join(",", numbers));

		}


	}
}
