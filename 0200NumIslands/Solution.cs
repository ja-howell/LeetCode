public class Solution
{
    public int NumIslands(char[][] grid)
    {
        int numIslands = 0;
        HashSet<Position> land = new();
        for (int r = 0; r < grid.Length; r++)
        {
            for (int c = 0; c < grid[r].Length; c++)
            {
                Position pos = new Position(r, c);
                if (grid[r][c] == '1' && !land.Contains(pos))
                {
                    // Console.WriteLine($"row: {r} col: {c}");
                    land.Add(pos);
                    numIslands++;
                    DFS(grid, pos, land);
                }
            }
        }
        
        return numIslands;
    }

    private class Position
    {
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
        public int row { get; set; }
        public int col { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Position other = (Position)obj;
            return row == other.row &&
                    col == other.col;                    
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = (hash * 23) + row.GetHashCode();
                hash = (hash * 23) + col.GetHashCode();
                return hash;
            }
        }
    }
    private static void DFS(char[][] grid, Position pos, HashSet<Position> land)
    {
        Stack<Position> frontier = new();
        frontier.Push(pos);
        while(frontier.Count > 0)
        {
            Position u = frontier.Pop();
            List<Position> neighbors = GetNeighbors(grid, u);
            // Console.Write($"Neighbors of u: [{u.row}, {u.col}] >");
            foreach (var neighbor in neighbors)
            {
                // Console.Write($"[{neighbor.row}, {neighbor.col}], ");
                if (!land.Contains(neighbor))
                {
                    frontier.Push(neighbor);
                    land.Add(neighbor);
                }
            }
            // Console.WriteLine();
        }
    }

    private static List<Position> GetNeighbors(char[][] grid, Position pos)
    {
        List<Position> neighbors = new();
        if (pos.col > 0 && grid[pos.row][pos.col - 1] == '1')
        {
            neighbors.Add(new Position(pos.row, pos.col - 1));
        }
        if (pos.col < grid[pos.row].Length - 1 && grid[pos.row][pos.col + 1] == '1')
        {
            neighbors.Add(new Position(pos.row, pos.col + 1));
        }
        if (pos.row > 0 && grid[pos.row - 1][pos.col] == '1')
        {
            neighbors.Add(new Position(pos.row - 1, pos.col));
        }
        if (pos.row < grid.Length - 1 && grid[pos.row + 1][pos.col] == '1')
        {
            neighbors.Add(new Position(pos.row + 1, pos.col));
        }

        return neighbors;
    }

}