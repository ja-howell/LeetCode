public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] products = new int[nums.Length];
        int totalProduct = 1;
        bool zeroSeen = false;
        bool twoZerosSeen = false;

        foreach (int num in nums)
        {
            if (num != 0)
            {
                totalProduct *= num;
            }
            else
            {
                if (zeroSeen)
                {
                    twoZerosSeen = true;
                    break;
                }
                zeroSeen = true;
            }
        }

        for (int i = 0; i < products.Length; i++)
        {
            if (twoZerosSeen)
            {
                products[i] = 0;
            }
            else if (zeroSeen)
            {
                if (nums[i] == 0)
                {
                    products[i] = totalProduct;
                }
                else
                {
                    products[i] = 0;
                }
            }
            else
            {
                products[i] = totalProduct / nums[i];
            }
        }

        return products;
    }
}