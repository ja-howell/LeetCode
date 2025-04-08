package main

func main() {}

func merge(nums1 []int, m int, nums2 []int, n int) {
	nums1Index := m - 1
	nums2Index := n - 1
	for i := n + m - 1; i >= 0; i-- {
		if nums2Index < 0 {
			break
		}
		if nums1Index < 0 || nums2[nums2Index] > nums1[nums1Index] {
			nums1[i] = nums2[nums2Index]
			nums2Index--
		} else {
			nums1[i] = nums1[nums1Index]
			nums1Index--
		}
	}
}
