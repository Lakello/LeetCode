namespace LeetCode.Tasks
{
	public class TaskTwoSum
	{
		public int[]? TwoSum(int[] nums, int target)
		{
			var dict = new Dictionary<int, int>();

			for (int i = 0; i < nums.Length; i++)
			{
				var num = target - nums[i];

				if (dict.TryGetValue(num, out var value))
				{
					return [value, i];
				}

				dict[nums[i]] = i;
			}

			return null;
		}
	}
}