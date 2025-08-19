package main

import "fmt"

func main() {
	nums := []int{2, 0, 2, 1, 1, 0}
	sortColors(nums)
	fmt.Println(nums)

}

// TODO Could you come up with a one-pass algorithm using only constant extra space?
func sortColors(nums []int) {
	//should be done inplace
	// order should be 0, 1, 2
	nextIndex := 0

	for i := 0; i < 3; i++ {
		nextIndex = sortColor(nums, i, nextIndex)
	}
}

func sortColor(nums []int, color int, nextIndex int) int {
	for i := nextIndex; i < len(nums); i++ {
		if nums[i] == color {
			nums[i] = nums[nextIndex]
			nums[nextIndex] = color
			nextIndex++
		}
	}
	return nextIndex
}
