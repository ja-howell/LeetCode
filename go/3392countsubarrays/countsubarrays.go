package main

import "fmt"

func main() {
	nums := []int{1, 2, 1, 4, 1}

	fmt.Println(countSubarrays(nums))

}

func countSubarrays(nums []int) int {
	i := 0
	validSubarrays := 0

	for i < len(nums)-2 {
		if isValidSubarray(nums, i) {
			validSubarrays++
		}
		i++
	}
	return validSubarrays
}

func isValidSubarray(nums []int, index int) bool {
	// fmt.Printf("index: %d, nums[index]: %d\n", index, nums[index])
	sum := nums[index] + nums[index+2]
	return sum*2 == nums[index+1]
}
