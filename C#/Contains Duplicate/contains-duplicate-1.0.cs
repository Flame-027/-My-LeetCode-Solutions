// Runtime beats 99% of leetcode submissions.

public class Solution {
    public bool ContainsDuplicate(int[] nums) 
	{
        if (nums == null || nums.Length <= 1) return false;

        Dictionary<int, int> hashtable = new();
        int i = 0;
        int j = nums.Length - 1;

        while(true)
        { 
            if (hashtable.ContainsKey(nums[i]))
                return true;

            if (i == j)
                return false;

            hashtable.TryAdd(nums[i], i);

            if (hashtable.ContainsKey(nums[j]))
                return true;

            hashtable.TryAdd(nums[j], j);

            if (j == i + 1)
                return false;

            i++;
            j--;
        }
    }	
}