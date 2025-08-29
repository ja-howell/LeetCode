package main

import (
	"fmt"
	"slices"
)

func main() {
	grid := [][]int{{1, 7, 3}, {9, 8, 2}, {4, 5, 6}}
	sortMatrix(grid)

	fmt.Println(grid)

}

type point struct {
	col int
	row int
}

func sortMatrix(grid [][]int) [][]int {
	grid = sortBottomTriangle(grid)
	grid = sortTopTriangle(grid)

	return grid
}

func buildDiagonal(grid [][]int, pos point) []int {
	length := len(grid[0])
	diagonal := []int{}
	//while in bounds
	// fmt.Printf("Build Diagonal: start= %v ", pos)
	for pos.col < length && pos.row < length {
		diagonal = append(diagonal, grid[pos.row][pos.col])
		pos.row++
		pos.col++
	}
	// fmt.Printf("sorted= %v\n", diagonal)
	return diagonal

}

func replaceDiagonal(grid [][]int, pos point, diagonal []int) [][]int {
	for _, val := range diagonal {
		grid[pos.row][pos.col] = val
		pos.row++
		pos.col++
	}
	return grid
}

func sortBottomTriangle(grid [][]int) [][]int {
	startRow := len(grid[0]) - 1 // bottom corner
	for startRow >= 0 {
		pos := point{row: startRow, col: 0}
		diagonal := buildDiagonal(grid, pos)
		slices.SortFunc(diagonal, func(a, b int) int {
			if b < a {
				return -1
			} else {
				return 1
			}
		})

		grid = replaceDiagonal(grid, pos, diagonal)
		startRow--
	}
	return grid
}

func sortTopTriangle(grid [][]int) [][]int {
	startCol := len(grid[0]) - 1 // top corner
	for startCol >= 1 {
		pos := point{row: 0, col: startCol}
		diagonal := buildDiagonal(grid, pos)
		slices.Sort(diagonal)

		grid = replaceDiagonal(grid, pos, diagonal)
		startCol--
	}
	return grid
}
