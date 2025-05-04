package main

import "fmt"

func main() {
	tops := []int{1, 2, 1, 1, 1, 2, 2, 2}
	bottoms := []int{2, 1, 2, 2, 2, 2, 2, 2}

	fmt.Println(minDominoRotations(tops, bottoms))

}

func minDominoRotations(tops []int, bottoms []int) int {
	numsCountTop := make(map[int]int)
	numsCountBottom := make(map[int]int)
	numsDoubles := make(map[int]int)

	for i := 0; i < len(tops); i++ {
		top := tops[i]
		bottom := bottoms[i]
		if top == bottom {
			// Take into account if the number is the same on the top and bottom
			numsDoubles[top]++
			if isPossible(numsCountTop[top], numsCountBottom[bottom], numsDoubles[top], len(tops)) {
				return min(numsCountTop[top], numsCountBottom[bottom])
			}
			continue
		}
		numsCountTop[top]++
		numsCountBottom[bottom]++

		doubleCount := numsDoubles[top]
		bottomCount := numsCountBottom[top]
		if isPossible(numsCountTop[top], bottomCount, doubleCount, len(tops)) {
			return min(numsCountBottom[top], numsCountTop[top])
		}
		doubleCount = numsDoubles[bottom]
		topCount := numsCountTop[bottom]
		if isPossible(topCount, numsCountBottom[bottom], doubleCount, len(tops)) {
			return min(numsCountBottom[bottom], numsCountTop[bottom])
		}
	}

	return -1
}

func isPossible(topCount int, bottomCount int, doubleCount int, numDominos int) bool {
	return topCount+bottomCount+doubleCount >= numDominos
}
