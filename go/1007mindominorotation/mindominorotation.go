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
			//Take into account if the number is the same on the top and bottom
			_, ok := numsDoubles[top]
			if !ok {
				numsDoubles[top] = 1
			} else {
				numsDoubles[top]++
			}
			if isPossible(numsCountTop[top], numsCountBottom[bottom], numsDoubles[top], len(tops)) {
				return min(numsCountTop[top], numsCountBottom[bottom])
			}
			continue
		}
		_, ok := numsCountTop[top]
		if !ok {
			numsCountTop[top] = 1
		} else {
			numsCountTop[top]++
		}
		_, ok = numsCountBottom[bottom]
		if !ok {
			numsCountBottom[bottom] = 1
		} else {
			numsCountBottom[bottom]++
		}
		doubleCount := getCount(numsDoubles, top)
		bottomCount := getCount(numsCountBottom, top)
		if isPossible(numsCountTop[top], bottomCount, doubleCount, len(tops)) {
			return min(numsCountBottom[top], numsCountTop[top])
		}
		doubleCount = getCount(numsDoubles, bottom)
		topCount := getCount(numsCountTop, bottom)
		if isPossible(topCount, numsCountBottom[bottom], doubleCount, len(tops)) {
			return min(numsCountBottom[bottom], numsCountTop[bottom])
		}
	}

	return -1
}

func isPossible(topCount int, bottomCount int, doubleCount int, numDominos int) bool {
	return topCount+bottomCount+doubleCount >= numDominos
}

func getCount(countMap map[int]int, num int) int {
	count, ok := countMap[num]
	if ok {
		return count
	}
	return 0
}
