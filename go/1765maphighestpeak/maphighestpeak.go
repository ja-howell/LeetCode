package main

import "fmt"

type Cell struct {
	row int
	col int
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
	// visited := map[]struct{}{}

	for row := 0; row < numRows; row++ {
		for col := 0; col < len(isWater[0]); col++ {
			if isWater[row][col] == 0 {
				//cell is land
				height[row][col] = -1
			} else {
				height[row][col] = 0
				queue = append(queue, Cell{row, col})
				// visited[{row, col}] = struct{}{}
			}
		}
	}

	// fmt.Printf("Starting queue: %v\n", queue)
	for len(queue) != 0 {
		cell := queue[0]
		queue = queue[1:]

		//Add NSWE cells if valid and if the height is -1
		for _, v := range getNeighbors(cell, numRows, numCols) {
			if height[v.row][v.col] == -1 {
				height[v.row][v.col] = height[cell.row][cell.col] + 1
				queue = append(queue, v)
			}
		}
		// fmt.Printf("Queue after pass: %v\nHeight: %v\n", queue, height)
	}

	return height
}

func isValid(row int, col int, numRows int, numCols int) bool {
	return row >= 0 && row < numRows && col >= 0 && col < numCols
}

func getNeighbors(cell Cell, numRows int, numCols int) []Cell {
	candidates := []Cell{
		{cell.row - 1, cell.col},
		{cell.row + 1, cell.col},
		{cell.row, cell.col - 1},
		{cell.row, cell.col + 1},
	}

	neighbors := []Cell{}
	for _, candidate := range candidates {
		if isValid(candidate.row, candidate.col, numRows, numCols) {
			neighbors = append(neighbors, candidate)
		}
	}

	return neighbors
}
