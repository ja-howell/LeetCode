package main

import "fmt"

func main() {
	flowerbed := []int{1, 0, 0, 0, 1}
	n := 1

	fmt.Println(canPlaceFlowers(flowerbed, n))
}

func canPlaceFlowers(flowerbed []int, n int) bool {
	if n == 0 {
		return true
	}
	prev := 0
	next := 0

	for i, pot := range flowerbed {
		// fmt.Printf("prev: %d next: %d curr: %d i: %d\n", prev, next, pot, i)
		if i == len(flowerbed)-1 {
			next = 0
		} else {
			next = flowerbed[i+1]
		}
		if pot == 0 && prev == 0 && next == 0 {
			n = n - 1
			if n == 0 {
				return true
			}
			pot = 1
		}
		prev = pot

	}
	return false
}
