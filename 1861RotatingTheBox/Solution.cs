public class Solution
{
    public char[][] RotateTheBox(char[][] box)
    {
        //1. rotate box
        //2. calculate new stone positions (apply gravity)
        //objets "*" are not affected by gravity
        int rows = box.Length;
        int cols = box[0].Length;
        char[][] newBox = ApplyGravity(box, rows, cols);

        return Rotate(newBox, rows, cols);
    }

    private char[][] Rotate(char[][] box, int rows, int cols)
    {
        //rotate the box 90 degrees
        char[][] rotatedBox = new char[cols][];
        //right col of box becomes bottom row of rotatedBox
        for (int c = 0; c < cols; c++)
        {
            //calculate the new Row and then copy it over
            char[] newRow = ColumnToRow(box, c);
            rotatedBox[c] = newRow;
        }
        return rotatedBox;
    }

    private char[][] ApplyGravity(char[][] box, int rows, int cols)
    {
        //right to left
        char[][] newBox = new char[rows][];
        for (int r = 0; r < rows; r++)
        {
            newBox[r] = new char[cols];
        }
        for (int r = 0; r < rows; r++)
        {
            int bottom = cols - 1;
            for (int c = cols - 1; c >= 0; c--)
            {
                if (box[r][c] == '*')
                {
                    newBox[r][c] = '*';
                    bottom = c - 1;
                }
                else if (box[r][c] == '#')
                {
                    newBox[r][c] = '.';
                    newBox[r][bottom] = '#';
                    bottom = bottom - 1;
                }
                else
                {
                    newBox[r][c] = '.';
                }
            }
        }
        // PrintMatrix(newBox);
        return newBox;
    }

    private char[] ColumnToRow(char[][] box, int c)
    {
        char[] newRow = new char[box.Length];
        int leftSide = 0;
        for (int r = box.Length - 1; r >= 0; r--)
        {
            newRow[r] = box[leftSide][c];
            leftSide++;
        }
        return newRow;
    }

    private void PrintMatrix(char[][] box)
    {
        Console.WriteLine("Print Matrix");
        for (int i = 0; i < box.Length; i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < box[0].Length; j++)
            {
                Console.Write(box[i][j] + " ");
            }
            Console.WriteLine("]");
        }
    }

}