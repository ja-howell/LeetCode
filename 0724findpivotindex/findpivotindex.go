package main

import "fmt"

func main() {
	nums := []int{1, 7, 3, 6, 5, 6}
	fmt.Println(pivotIndex(nums))
}

func pivotIndex(nums []int) int {
	leftSum := 0

	totalSum := calcTotalSum(nums)
	rightSum := totalSum

	for i := 0; i < len(nums); i++ {
		rightSum -= nums[i]
		if rightSum == leftSum {
			return i
		}
		leftSum += nums[i]
	}
	return -1
}

func calcTotalSum(nums []int) int {
	totalSum := 0
	for _, num := range nums {
		totalSum += num
	}
	return totalSum
}
