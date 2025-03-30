package main

import "fmt"

func main() {

	nums := []int{4, 1, 3, 3}

	fmt.Println(countBadPairs(nums))

}

func countBadPairs(nums []int) int64 {
	freq := map[int]int{}
	for i, v := range nums {
		freq[v-i]++
	}

	total := int64(0)

	for _, f := range freq {
		total += nChoose2(f)
	}

	return nChoose2(len(nums)) - total

}

func nChoose2(n int) int64 {
	return int64((n * (n - 1)) / 2)
}
