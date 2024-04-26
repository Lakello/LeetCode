namespace AddTwoNumbers
{
	public static class DebugTask
	{
		public static void Run()
		{
			var data = new TestData();

			var task = new TaskAddTwoNumbers();

			var result = task.AddTwoNumbers(data.l1, data.l2);
			
			Console.Write("[");
			while (result != null)
			{
				Console.Write($"{result.val}, ");
				result = result.next;
			}
			Console.Write("]");
		}
	}
}