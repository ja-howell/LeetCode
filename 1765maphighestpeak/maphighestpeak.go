package main

import "fmt"

type Position struct {
	row int
	col int
}

type Cell struct {
	Position
	height int
}

func main() {
	isWater := [][]int{
		{0, 0, 1},
		{1, 0, 0},
		{0, 0, 0},
	}

	fmt.Println(highestPeak(isWater))
}

func highestPeak(isWater [][]int) [][]int {
	height := isWater
	queue := []Cell{}
	numRows := len(isWater)
	numCols := len(isWater[0])
	visited := map[Position]struct{}{}

	for row := 0; row < numRows; row++ {
		for col := 0; col < len(isWater[0]); col++ {
			if isWater[row][col] == 0 {
				//cell is land
				height[row][col] = -1
			} else {
				height[row][col] = 0
				queue = append(queue, Cell{Position{row, col}, 0})
				visited[Position{row, col}] = struct{}{}
			}
		}
	}

	// fmt.Printf("Starting queue: %v\n", queue)
	for len(queue) != 0 {
		cell := queue[0]
		queue = queue[1:]

		if height[cell.row][cell.col] == -1 {
			height[cell.row][cell.col] = cell.height
		}
		//Add NSWE cells if valid and if the height is -1
		if isValidPosition(cell.row-1, cell.col, numRows, numCols) && height[cell.row-1][cell.col] == -1 {
			if _, ok := visited[Position{cell.row - 1, cell.col}]; !ok {
				queue = append(queue, Cell{Position{cell.row - 1, cell.col}, cell.height + 1})
				visited[Position{cell.row - 1, cell.col}] = struct{}{}
			}
		}
		if isValidPosition(cell.row+1, cell.col, numRows, numCols) && height[cell.row+1][cell.col] == -1 {
			if _, ok := visited[Position{cell.row + 1, cell.col}]; !ok {
				queue = append(queue, Cell{Position{cell.row + 1, cell.col}, cell.height + 1})
				visited[Position{cell.row + 1, cell.col}] = struct{}{}
			}
		}
		if isValidPosition(cell.row, cell.col-1, numRows, numCols) && height[cell.row][cell.col-1] == -1 {
			if _, ok := visited[Position{cell.row, cell.col - 1}]; !ok {
				queue = append(queue, Cell{Position{cell.row, cell.col - 1}, cell.height + 1})
				visited[Position{cell.row, cell.col - 1}] = struct{}{}
			}
		}
		if isValidPosition(cell.row, cell.col+1, numRows, numCols) && height[cell.row][cell.col+1] == -1 {
			if _, ok := visited[Position{cell.row, cell.col + 1}]; !ok {
				queue = append(queue, Cell{Position{cell.row, cell.col + 1}, cell.height + 1})
				visited[Position{cell.row, cell.col + 1}] = struct{}{}
			}
		}
		// fmt.Printf("Queue after pass: %v\nHeight: %v\n", queue, height)
	}

	return height
}

func isValidPosition(row int, col int, numRows int, numCols int) bool {
	return row >= 0 && row < numRows && col >= 0 && col < numCols
}
