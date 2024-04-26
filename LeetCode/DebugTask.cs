using LeetCode.Tasks;

namespace LeetCode
{
	public static class DebugTask
	{
		public static void Run()
		{
			var input = Console.ReadLine();

			int[] result;
			var task = new TaskTwoSum();

			if (input == "y")
			{
				var (nums, target) = GetValues();

				result = task.TwoSum(nums, target);
			}
			else
			{
				result = task.TwoSum(TestData.Nums, TestData.Target);
			}

			Console.WriteLine($"[{result[0]}, {result[1]}]");
		}

		private static T GetInput<T>(string message, Func<string, T> action)
		{
			string input = string.Empty;

			while (input == string.Empty)
			{
				Console.WriteLine(message);
				input = Console.ReadLine() ?? string.Empty;
			}

			return action(input);
		}

		private static IEnumerable<char> RemoveLetters(string input) =>
			input.Where(c => Char.IsLetter(c) == false);

		private static (int[], int) GetValues()
		{
			int[] nums = GetInput<int[]>(
				"NUMS",
				(input) =>
				{
					var inputNums = RemoveLetters(input).ToArray();

					return Array.ConvertAll(inputNums, c => (int)Char.GetNumericValue(c));
				});

			int target = GetInput<int>(
				"TARGET",
				(input) =>
				{
					var inputNums = RemoveLetters(input).ToArray();
					string number = string.Empty;

					foreach (var num in inputNums)
					{
						number += num;
					}

					return int.Parse(number);
				});

			return (nums, target);
		}
	}
}