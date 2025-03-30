package main

import "fmt"

func main() {
	gain := []int{-5, 1, 5, 0, -7}

	fmt.Println(largestAltitude(gain))
}

func largestAltitude(gain []int) int {
	highestAlt := 0

	currAlt := 0

	for _, altGain := range gain {
		currAlt += altGain
		if currAlt > highestAlt {
			highestAlt = currAlt
		}
	}

	return highestAlt
}
