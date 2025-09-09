package main

import (
	"fmt"
)

func main() {
	fmt.Println(generate(5))
}

func generate(numRows int) [][]int {
	if numRows == 1 {
		return [][]int{{1}}
	}
	prevRow := []int{1, 1}
	triangle := [][]int{{1}, {1, 1}}
	for i := 0; i < numRows-2; i++ {
		row := buildRow(prevRow)
		triangle = append(triangle, row)
		prevRow = row
	}
	return triangle
}

func buildRow(prevRow []int) []int {
	row := []int{1}
	for j := 1; j < len(prevRow); j++ {
		row = append(row, prevRow[j-1]+prevRow[j])
	}
	row = append(row, 1)
	return row
}
