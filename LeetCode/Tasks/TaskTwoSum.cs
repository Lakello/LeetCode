// ReSharper disable once IdentifierTypo
namespace LeetCode.Tasks
{
	public class TaskTwoSum
	{
		private int _target;
		private int[] _nums;

		public int[] TwoSum(int[] nums, int target)
		{
			_target = target;
			
			_nums = nums;
			
			return GetSumIndices();
		}

		private int[] GetSumIndices()
		{
			for (int i = 0; i < _nums.Length; i++)
			{
				var targetNum = _target - _nums[i];
				
				if (TryGetIndexTarget(targetNum, out var index, i))
				{
					if (index != i)
					{
						return [index, i];
					}
				}
			}
			
			return null;
		}

		private bool TryGetIndexTarget(int target, out int targetIndex, int currentIndex)
		{
			for (int i = currentIndex + 1; i < _nums.Length; i++)
			{
				if (_nums[i].Equals(target))
				{
					targetIndex = i;

					return true;
				}
			}

			targetIndex = -1;

			return false;
		}
	}
}