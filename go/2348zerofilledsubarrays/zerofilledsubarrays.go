package main

func main() {
	nums := []int{1, 3, 0, 0, 2, 0, 0, 4}
	result := zeroFilledSubarray(nums)
	println(result) // Output: 6
}

func zeroFilledSubarray(nums []int) int64 {
	subarrayLength := 0
	numSubarrays := int64(0)
	for _, num := range nums {
		if num == 0 {
			subarrayLength++
			numSubarrays += int64(subarrayLength)
		} else {
			subarrayLength = 0
		}
	}
	return numSubarrays
}
