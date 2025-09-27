package main

import (
	"fmt"
)

func main() {
	richer := [][]int{{1, 0}, {2, 1}, {3, 1}, {3, 7}, {4, 3}, {5, 3}, {6, 3}}
	quiet := []int{3, 2, 5, 4, 6, 1, 7, 0}
	fmt.Println(loudAndRich(richer, quiet))
}

func loudAndRich(richer [][]int, quiet []int) []int {

	graph := map[int][]int{}

	for i := 0; i < len(quiet); i++ {
		graph[i] = []int{}
	}

	for _, edge := range richer {
		to, from := edge[0], edge[1]
		graph[from] = append(graph[from], to)
	}

	answer := []int{}

	for i := 0; i < len(quiet); i++ {
		answer = append(answer, dfs(graph, i, quiet, map[int]int{}))
	}

	return answer

}

func dfs(graph map[int][]int, start int, quiet []int, memo map[int]int) int {

	if val, ok := memo[start]; ok {
		return val
	}
	neighbors := graph[start]
	quietest := start
	quietestLevel := quiet[start]
	for _, neighbor := range neighbors {
		quietestNeighbor := dfs(graph, neighbor, quiet, memo)
		if quietestLevel > quiet[quietestNeighbor] {
			quietest = quietestNeighbor
			quietestLevel = quiet[quietestNeighbor]
		}
	}
	memo[start] = quietest
	return quietest
}
