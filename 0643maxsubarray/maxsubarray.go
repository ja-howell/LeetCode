package main

import (
	"fmt"
	"slices"
)

func main() {
	nums := []int{1, 12, -5, -6, 50, 3}
	k := 4

	fmt.Println(findMaxAverage(nums, k))
}

func findMaxAverage(nums []int, k int) float64 {
	subArraySum := 0
	maxAverage := 0.0000
	subArray := []int{}

	for i := 0; i < k; i++ {
		subArray = append(subArray, nums[i])
		subArraySum += nums[i]
	}

	maxAverage = float64(subArraySum) / float64(k)

	for i := k; k < len(nums); i++ {
		subArraySum -= subArray[0]
		subArray = slices.Delete(subArray, 0, 1)
		subArray = append(subArray, nums[i])
		subArraySum += nums[i]
		if maxAverage < float64(subArraySum)/float64(k) {
			maxAverage = float64(subArraySum) / float64(k)
		}
	}
	return maxAverage
}
