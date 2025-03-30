package main

import "fmt"

func main() {
	n := 1

	fmt.Println(coloredCells(n))
}

func coloredCells(n int) int64 {
	width := 2*n - 1
	height := width
	area := int64(width) * int64(height)

	return (area / 2) + 1

}
