package main

import "fmt"

func main() {
	nums := []int{1, 5, 0, 4, 1, 3}
	fmt.Println(increasingTriplet(nums))
}

// func increasingTriplet(nums []int) bool {
// 	one := 0
// 	two := 0
// 	doubleFound := false
// 	for i, num := range nums {
// 		one = num
// 		for j := i + 1; j < len(nums); j++ {
//             fmt.Printf("one: %d, two: %d, df: %v, nums[j]: %d\n", one, two, doubleFound, nums[j])
// 			if nums[j] > one && !doubleFound {
// 				two = nums[j]
//                 doubleFound = true
// 			} else if nums[j] > two && doubleFound {
// 				return true
// 			}
// 		}
// 		two = 0
//         doubleFound = false
// 	}
// 	return false
// }

// func increasingTriplet(nums []int) bool {
// 	one := 0
// 	two := 0
// 	for i, num := range nums {
// 		one = num
// 		for j := i + 1; j < len(nums); j++ {
// 			if nums[j] > one {
// 				two = nums[j]
// 				for k := j + 1; k < len(nums); k++ {
// 					if nums[k] > two {
// 						return true
// 					}
// 				}
// 			}
// 			two = 0
// 		}
// 	}
// 	return false
// }

//[1,5,0,4,1,3]
func increasingTriplet(nums []int) bool {
	one := 0
	two := 0
	var smallest *int
	var secondSmallest *int
	for i, num := range nums {
		if smallest == nil || num < *smallest {
			one = num
			smallest = &num
			for j := i + 1; j < len(nums); j++ {
				if nums[j] > one {
					if secondSmallest == nil || nums[j] < *secondSmallest {
						temp := nums[j]
						two = temp
						secondSmallest = &temp
						if findValidK(nums, j, two) {
							return true
						}
					}
					two = 0
				}
			}
			secondSmallest = nil
		}
	}
	return false
}

func findValidK(nums []int, j int, two int) bool {
	for k := j + 1; k < len(nums); k++ {
		if nums[k] > two {
			return true
		}
	}
	return false
}
