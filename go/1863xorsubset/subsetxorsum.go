package main

import "fmt"

func main() {
	nums := []int{3, 4, 5, 6, 7, 8}

	fmt.Println(subsetXORSum(nums))
}

func subsetXORSum(nums []int) int {
	return subsetXOR(nums, 0, 0)
}

func subsetXOR(nums []int, index int, curSum int) int {
	if index >= len(nums) {
		return curSum
	}

	xorWithIndex := subsetXOR(nums, index+1, curSum^nums[index])
	xorWithoutIndex := subsetXOR(nums, index+1, curSum)

	return xorWithIndex + xorWithoutIndex
}
