package main

import "fmt"

func main() {

	grid := [][]int{
		{1, 3, 1, 15},
		{1, 3, 3, 1},
	}

	fmt.Println(gridGame(grid))

}

func gridGame(grid [][]int) int64 {
	topRow := grid[0]
	bottomRow := grid[1]
	prepivot := int64(0)
	postpivot := sum(topRow[1:])
	minBestScore := postpivot

	for pivot := 1; pivot < len(topRow); pivot++ {
		// fmt.Printf("pivot: %v post: %v pre: %v\n", pivot, postpivot, prepivot)
		prepivot = prepivot + int64(bottomRow[pivot-1])
		postpivot = postpivot - int64(topRow[pivot])
		maxScore := max(prepivot, postpivot)
		minBestScore = min(minBestScore, maxScore)

	}
	prepivot = prepivot + int64(bottomRow[len(bottomRow)-1])
	minBestScore = min(minBestScore, prepivot)
	// fmt.Printf("post: %v pre: %v\n", postpivot, prepivot)

	return minBestScore
}

func sum(x []int) int64 {
	total := 0
	for _, val := range x {
		total += val
	}
	return int64(total)
}
