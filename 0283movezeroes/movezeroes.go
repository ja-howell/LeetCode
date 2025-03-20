package main

func main() {}

func moveZeroes(nums []int) {
	lastZeroIndex := 0
	totalZeroes := 0

	for _, num := range nums {
		if num == 0 {
			totalZeroes++
		} else {
			nums[lastZeroIndex] = num
			lastZeroIndex++
		}
	}

	numsLength := len(nums)

	for i := numsLength - totalZeroes; i < numsLength; i++ {
		nums[i] = 0
	}
}
