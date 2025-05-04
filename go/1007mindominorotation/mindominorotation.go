package main

import "fmt"

func main() {
	tops := []int{1, 1, 2}
	bottoms := []int{2, 3, 4}

	fmt.Println(minDominoRotations(tops, bottoms))

}

func minDominoRotations(tops []int, bottoms []int) int {
	numsCountTop := make(map[int]int)
	numsCountBottom := make(map[int]int)
	doubleVal := -1

	validSet := map[int]struct{}{
		tops[0]:    {},
		bottoms[0]: {},
	}
	// 1 1 2
	// 2 3 4

	for i := range len(tops) {
		top := tops[i]
		bottom := bottoms[i]
		_, containsTop := validSet[top]
		_, containsBottom := validSet[bottom]
		if !containsTop && !containsBottom {
			return -1
		}

		if !containsBottom {
			validSet = map[int]struct{}{top: {}}
		} else if !containsTop {
			validSet = map[int]struct{}{bottom: {}}
		}
		if top == bottom {
			if doubleVal == -1 {
				doubleVal = top
			} else if doubleVal != top {
				return -1
			}
			// Double dominos will never flip, so don't count them
			continue
		}
		if containsTop {
			numsCountTop[top]++
		}
		if containsBottom {
			numsCountBottom[bottom]++
		}

	}

	top := tops[len(tops)-1]
	if _, containsTop := validSet[top]; containsTop {
		return min(numsCountBottom[top], numsCountTop[top])
	}

	bottom := bottoms[len(bottoms)-1]
	if _, containsBottom := validSet[bottom]; containsBottom {
		return min(numsCountBottom[bottom], numsCountTop[bottom])
	}

	return -1
}
