package main

import (
	"fmt"
	"strconv"
)

func main() {

	nums := []int{18, 43, 36, 13, 7}
	fmt.Println(maximumSum(nums))

}

func maximumSum(nums []int) int {
	max := -1
	pairs := map[int][]int{}

	for _, v := range nums {
		digitSum := sumDigits(v)
		if len(pairs[digitSum]) >= 1 {
			temp := findMax(pairs[digitSum], v)
			if temp > max {
				max = temp
			}
		}
		pairs[digitSum] = append(pairs[digitSum], v)
	}

	return max
}

func sumDigits(num int) int {
	sum := 0
	strNum := strconv.Itoa(num)
	for _, char := range strNum {
		digit, err := strconv.Atoi(string(char))
		if err != nil {
			fmt.Println(err)
		}
		sum += digit

	}
	return sum
}

func findMax(nums []int, x int) int {
	max := -1
	for _, v := range nums {
		candidate := v + x
		if candidate > max {
			max = candidate
		}
	}
	return max
}
