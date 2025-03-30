package main

import "slices"

func main() {}

func findDifference(nums1 []int, nums2 []int) [][]int {
	nums1Set := map[int]struct{}{}
	nums2Set := map[int]struct{}{}

	for _, num := range nums1 {
		nums1Set[num] = struct{}{}
	}
	for _, num := range nums2 {
		nums2Set[num] = struct{}{}
	}

	distinctNums := [][]int{}
	nums1Distinct := []int{}
	nums2Distinct := []int{}

	for _, num := range nums1 {
		_, ok := nums2Set[num]
		if !ok && !slices.Contains(nums1Distinct, num) {
			nums1Distinct = append(nums1Distinct, num)

		}
	}
	for _, num := range nums2 {
		_, ok := nums1Set[num]
		if !ok && !slices.Contains(nums2Distinct, num) {
			nums2Distinct = append(nums2Distinct, num)
		}
	}
	distinctNums = append(distinctNums, nums1Distinct)
	distinctNums = append(distinctNums, nums2Distinct)
	return distinctNums
}
