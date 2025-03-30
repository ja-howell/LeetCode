package main

import "fmt"

func twoSum(nums []int, target int) []int {
	seenToIndex := make(map[int]int)
	for i, v := range nums {
		diff := target - v
		x, ok := seenToIndex[diff]
		if ok {
			return []int{x, i}
		}
		seenToIndex[v] = i
	}
	return []int{}
}

func main() {
	nums := []int{2, 7, 11, 15}
	target := 9

	fmt.Println(twoSum(nums, target))

}
