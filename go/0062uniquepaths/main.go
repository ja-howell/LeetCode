package main

import "fmt"

func main() {
	fmt.Println(uniquePaths(3, 7))
}

func uniquePaths(m int, n int) int {
	grid := buildGrid(m, n)

	return grid[m-1][n-1]
}

func buildGrid(rows int, cols int) [][]int {
	grid := make([][]int, rows)

	grid[0] = make([]int, cols)
	for c := 1; c <= cols-1; c++ {
		grid[0][c] = 1
	}

	for r := 1; r <= rows-1; r++ {
		grid[r] = make([]int, cols)
		grid[r][0] = 1
	}

	for r := 1; r <= rows-1; r++ {
		for c := 1; c <= cols-1; c++ {
			grid[r][c] = grid[r-1][c] + grid[r][c-1]
		}
	}

	return grid
}
