namespace AddTwoNumbers
{
	public struct TestData
	{
		public ListNode l1;
		public ListNode l2;

		public TestData()
		{
			l1 = FillList([2, 4, 3]);
			l2 = FillList([5, 6, 4]);
		}

		private ListNode FillList(int[] values)
		{
			List<ListNode> nodes = new List<ListNode>();
			
			for (int i = 0; i < values.Length; i++)
			{
				nodes.Add(new ListNode(values[i]));
			}

			for (int i = 0; i < nodes.Count - 1; i++)
			{
				nodes[i].next = nodes[i + 1];
			}

			return nodes[0];
		}
	}
}