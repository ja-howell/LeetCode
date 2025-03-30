package main

import (
	"fmt"
)

func main() {

	nums := []int{9, 12, 5, 10, 14, 3, 10}
	pivot := 10

	fmt.Println(pivotArray(nums, pivot))

}

func pivotArray(nums []int, pivot int) []int {

	leftArray := []int{}
	pivotArray := []int{}
	rightArray := []int{}

	pivotedArray := make([]int, 0, len(nums))

	for _, val := range nums {
		if val > pivot {
			rightArray = append(rightArray, val)
		} else if val < pivot {
			leftArray = append(leftArray, val)
		} else {
			pivotArray = append(pivotArray, val)
		}
	}
	pivotedArray = append(leftArray, pivotArray...)
	pivotedArray = append(pivotedArray, rightArray...)
	return pivotedArray
}
