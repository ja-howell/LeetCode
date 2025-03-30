public class Solution {
    public int[] Decrypt(int[] code, int k) {
        // code is circular
        int[] decoded = new int[code.Length];
        if (k == 0)
        {
            // replace code with all 0s
        }
        else if (k > 0)
        {
            // replace ith number with sum of of the next k numbers
            for (int i = 0; i < code.Length; i++)
            {
                decoded[i] = AddNextKNums(code, k, i);
            }  
        }
        else
        {
            // replace ith number with sum of the prev k numbers
            for (int i = 0; i < code.Length; i++)
            {
                decoded[i] = AddPrevKNums(code, k, i);
            }  
        }
        
        return decoded;
        
    }

    private static int AddNextKNums(int[] code, int k, int i)
    {
        int sum = 0;
        while (k > 0)
        {
            if ((k + i) >= code.Length)
            {
                sum += code[((k + i) - code.Length )];
            }
            else 
            {
                sum += code[k + i];
            }
            k--;
        }
        return sum;
    }    private static int AddPrevKNums(int[] code, int k, int i)
    {
        // Fix ME!!!
        int sum = 0;
        Console.WriteLine("k " + k + " i " + i);

        while (k < 0)
        {
            if ((k + i) < 0)
            {
                sum += code[((code.Length) + (k + i) )];
                Console.WriteLine(sum);
            }
            else 
            {
                sum += code[k + i];
                Console.WriteLine("else: " + sum);
            }
            k++;
        }
        Console.WriteLine(sum);
        return sum;
    }
}