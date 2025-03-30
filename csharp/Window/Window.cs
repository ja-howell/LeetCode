public class Window
{
    //What props should a window have?
    //1. A window should have a left and right barrier
    //2. A set of seen numbers   
    //3. Sum?
    //4. Valid?

    //What methods should a window have?
    //1. A window should be able to go to the next window
    //2. A window should be able to go to the prev window
    //3. Calculate the sum of the current window
    //4. Check if a window is valid
    private int left;
    private int right;
    private int[] nums;
    private Dictionary<int, int>? seen;
    private long sum;
    private int size;
    public Window(int[] nums, int left, int right)
    {
        this.left = left;
        this.right = right;
        this.nums = nums;
        CalculateInitialSum();
        this.size = right - left + 1;
        FillDict();

    }

    public void Next()
    {
        this.right += 1;
        if (this.seen.ContainsKey(this.nums[right]))
        {
            int currVal = this.seen[this.nums[this.right]];
            this.seen[this.nums[this.right]] = currVal + 1;
        }
        else
        {
            this.seen.Add(this.nums[this.right], 1);
        }
        if (this.seen[this.nums[this.left]] > 1)
        {
            int currVal = this.seen[nums[left]];
            this.seen[this.nums[this.left]] = currVal - 1; 
        }
        else
        {
            this.seen.Remove(this.nums[this.left]);
        }
        this.left += 1;
        CalculateSum();
    }

    private void CalculateInitialSum()
    {
        for (int i = this.left; i <= this.right; i++)
        {
            this.sum += nums[i];
        }
    }
    private void CalculateSum()
    {
        this.sum -= nums[left - 1];
        this.sum += nums[right];
    }
    public bool IsValid()
    {
        //If no duplicates
        if (this.seen?.Count != (this.size))
        {
            return false;
        }
        return true;
    }
    public bool HasNext()
    {
        return this.right + 1 < nums.Length;
    }
    private void FillDict()
    {
        this.seen = new Dictionary<int, int>();
        for (int i = this.left; i <= this.right; i++)
        {
            if (this.seen.ContainsKey(nums[i]))
            {
                int currVal = this.seen[nums[i]];
                this.seen[nums[i]] = currVal + 1;
            }
            else
            {
                this.seen.Add(nums[i], 1);

            }
        }
    }
    public long GetSum()
    {
        return this.sum;
    }






}