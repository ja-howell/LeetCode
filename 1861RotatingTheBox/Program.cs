using System;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        char[][] box = new char[][]
        {
            new char[] {'#','.','*','.'},
            new char[] {'#','#','*','.'}
        };

        // for (int i = 0; i < box.Length; i++)
        // {
        //     Console.Write("[ ");
        //     for (int j = 0; j < box[0].Length; j++)
        //     {
        //         Console.Write(box[i][j] + " ");
        //     }
        //     Console.WriteLine("]");
        // }


        char[][] rotatedBox = solution.RotateTheBox(box);
        // Console.WriteLine("Rotated Box");

        // for (int i = 0; i < rotatedBox.Length; i++)
        // {
        //     Console.Write("[ ");
        //     for (int j = 0; j < rotatedBox[0].Length; j++)
        //     {
        //         Console.Write(rotatedBox[i][j] + " ");
        //     }
        //     Console.WriteLine("]");
        // }
    }
}