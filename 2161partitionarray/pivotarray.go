package main

import (
	"fmt"
	"slices"
)

func main() {

	nums := []int{9, 12, 5, 10, 14, 3, 10}
	pivot := 10

	fmt.Println(pivotArray(nums, pivot))

}

func pivotArray(nums []int, pivot int) []int {

	left := 0

	pivotedArray := make([]int, 0, len(nums))

	for _, val := range nums {
		if val > pivot {
			pivotedArray = append(pivotedArray, val)
		} else if val < pivot {
			pivotedArray = slices.Insert(pivotedArray, left, val)
			left++
		} else {
			pivotedArray = slices.Insert(pivotedArray, left, val)
		}
	}
	return pivotedArray
}
