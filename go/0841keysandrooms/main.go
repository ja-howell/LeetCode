package main

import (
	"fmt"
	"slices"
)

func main() {
	rooms := [][]int{[]int{1}, []int{2}, []int{3}, []int{}}

	fmt.Println(canVisitAllRooms(rooms))
}

func canVisitAllRooms(rooms [][]int) bool {
	visited := make([]bool, len(rooms))
	visited[0] = true
	keys := append([]int{}, rooms[0]...)

	for len(keys) > 0 {
		currRoom := keys[0]
		keys = keys[1:]
		if !visited[currRoom] {
			visited[currRoom] = true
			keys = append(keys, rooms[currRoom]...)
		}
	}

	return !slices.Contains(visited, false)
}
