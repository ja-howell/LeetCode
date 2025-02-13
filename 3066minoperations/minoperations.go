package main

import (
	"fmt"
	"math"
	"slices"
)

func main() {

	nums := []int{2, 11, 10, 1, 3}
	k := 10

	fmt.Println(minOperations(nums, k))
}

func minOperations(nums []int, k int) int {
	minOps := 0

	slices.Sort(nums)

	for nums[0] < k {
		nums = performOperation(nums, k)
		minOps++
	}

	return minOps
}

func performOperation(nums []int, k int) []int {
	//remove two smallest nums (x, y)
	//Insert (min(x, y) * 2 + max(x, y))

	x := float64(nums[0])
	y := float64(nums[1])

	nums = nums[2:]
	num := int((math.Min(x, y)*2 + math.Max(x, y)))

	// nums = append(nums, num)

	// if num < k {
	// 	slices.Sort(nums)
	// }
	// slices.Sort(nums)

	return insertNum(nums, num, k)

}

func insertNum(nums []int, num int, k int) []int {
	for i, v := range nums {
		if v > k {
			nums = slices.Insert(nums, i+1, num)
			return nums
		}
	}
	nums = append(nums, num)

	return nums
}
