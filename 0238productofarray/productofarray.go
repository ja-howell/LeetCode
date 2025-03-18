package main

import "fmt"

func main() {
	nums := []int{1, 2, 3, 4}

	fmt.Println(productExceptSelf(nums))
}

func productExceptSelf(nums []int) []int {
	n := len(nums)
	products := make([]int, n)
	curr := 1
	for i, num := range nums {
		products[i] = 1
		products[i] *= curr
		curr *= num
	}
	curr = 1
	for i := n - 1; i >= 0; i-- {
		products[i] *= curr
		curr *= nums[i]
	}
	return products
}
