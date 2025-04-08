package main

import (
	"slices"
)

func main() {

}

func hIndex(citations []int) int {
	slices.SortFunc(citations, func(a, b int) int {
		return b - a
	})

	for i, c := range citations {
		if c < i+1 {
			return i
		}
	}
	return len(citations)
}
