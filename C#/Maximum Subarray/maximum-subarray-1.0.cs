namespace Program
{
    class program
    {
        public int MaxSubArray(int[] nums)
        {

          int maybeMax = nums[0];
          int max= nums[0];

          for (var i = 1; i <= nums.Length - 1; i++)
          {
           maybeMax += nums[i];
           maybeMax = Math.Max(maybeMax, nums[i]);
           max = Math.Max(maybeMax, max);
          }
          return max;
        } 
    }

    // Constraints : input will always be a single int[] , output must be int[2] and contain the largest sum , solution must be < O(n)

    // step 1 : loop through array and start adding elements to total
                // step 1 : during loop if current index is larger than maybeMax - total, update maybeMax to equal current index
                // step 2 : if maybeMax is larger than Max then Max equals to total
}
