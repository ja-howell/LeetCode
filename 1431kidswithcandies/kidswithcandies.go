package main

import "fmt"

func main() {
	candies := []int{2, 3, 5, 1, 3}
	extra := 3

	fmt.Println(kidsWithCandies(candies, extra))
}

func kidsWithCandies(candies []int, extraCandies int) []bool {
	greatest := 0
	for _, numCandy := range candies {
		if numCandy > greatest {
			greatest = numCandy
		}
	}

	isGreatest := make([]bool, len(candies))
	for i, numCandy := range candies {
		if numCandy+extraCandies >= greatest {
			isGreatest[i] = true
		}
	}
	return isGreatest
}
