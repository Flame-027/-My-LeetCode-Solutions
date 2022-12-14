public class Solution 
{
    public void Rotate(int[] nums, int k)
    {
        if (nums == null) {}
        else if (nums.Length < 2 || k < 1) {}
        else
        {
            var orignal = nums[..];

            for (int i = 0; i < nums.Length; i++)
            {
                var tempIndex = i + k;

                if (tempIndex > nums.Length - 1)
                {
                   tempIndex = adjustIndex(tempIndex, nums.Length);
                }

                nums[tempIndex] = orignal[i];

               
            }
        }
            
        int adjustIndex(int tempIndex, int length)
        {
           var maxIndex = length - 1;

           while (tempIndex > maxIndex)
                 tempIndex += - maxIndex - 1;

           return tempIndex;
        }
    }
}
