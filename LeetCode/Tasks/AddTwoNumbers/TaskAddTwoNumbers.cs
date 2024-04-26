namespace AddTwoNumbers
{
	public class TaskAddTwoNumbers
	{
		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			var result = new ListNode();
			
			Add(l1, l2, result);
			
			return result;
		}

		private void Add(ListNode? l1, ListNode? l2, ListNode current, int remnant = 0)
		{
			ListNode next1 = null;
			ListNode next2 = null;

			AddList(l1, ref next1);
			AddList(l2, ref next2);
			
			current.val += remnant;
			remnant = 0;
			
			if (current.val >= 10)
			{
				remnant++;
				current.val -= 10;
			}

			if (next1 != null || next2 != null || remnant != 0)
			{
				current.next = new ListNode();
				
				Add(next1, next2, current.next, remnant);
			}
			
			return;

			void AddList(ListNode? list, ref ListNode nextList)
			{
				if (list == null)
					return;
				
				current.val += list.val;

				if (list.next != null)
					nextList = list.next;
			}
		}
	}
}