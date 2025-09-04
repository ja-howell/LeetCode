package main

import (
	"container/heap"
	"fmt"
	"slices"
)

func main() {
	graph := make(map[rune][]edge)

	// Example graph
	graph['A'] = []edge{{destination: 'B', distance: 1}, {destination: 'C', distance: 4}}
	graph['B'] = []edge{{destination: 'A', distance: 1}, {destination: 'C', distance: 2}, {destination: 'D', distance: 5}}
	graph['C'] = []edge{{destination: 'A', distance: 4}, {destination: 'B', distance: 2}, {destination: 'D', distance: 1}}
	graph['D'] = []edge{{destination: 'B', distance: 5}, {destination: 'C', distance: 1}}

	s := 'A'
	dest := 'D'
	path := dijkstras(graph, s, dest)
	fmt.Printf("%v\n", path)
}

func dijkstras(graph map[rune][]edge, start rune, dest rune) []rune {
	distanceTo := map[rune]int{}
	parentOf := map[rune]rune{}
	distanceTo[start] = 0
	pq := &PriorityQueue{}
	heap.Push(pq, Item{
		node:     start,
		priority: 0,
	})
	for pq.Len() > 0 {
		item := heap.Pop(pq)
		node := item.(Item).node
		if node == dest {
			path := []rune{}
			for node != start {
				path = append(path, node)
				node = parentOf[node]
			}
			path = append(path, node)
			slices.Reverse(path)

			return path
		}
		for _, edge := range graph[node] {
			neighbor := edge.destination
			dist, ok := distanceTo[neighbor]
			if !ok || dist > distanceTo[node]+edge.distance {
				distanceTo[neighbor] = distanceTo[node] + edge.distance
				parentOf[neighbor] = node
				heap.Push(pq, Item{
					node:     neighbor,
					priority: distanceTo[neighbor],
				})
			}

		}
	}
	return nil
}

type edge struct {
	destination rune
	distance    int
}

type Item struct {
	node     rune
	priority int
}

type PriorityQueue []Item

func (pq *PriorityQueue) Len() int {
	return len(*pq)
}

func (pq *PriorityQueue) Less(i, j int) bool {
	return (*pq)[i].priority < (*pq)[j].priority
}

func (pq *PriorityQueue) Swap(i, j int) {
	(*pq)[i], (*pq)[j] = (*pq)[j], (*pq)[i]
}

func (pq *PriorityQueue) Push(x any) {
	item := x.(Item)
	*pq = append(*pq, item)
}

func (pq *PriorityQueue) Pop() any {
	item := (*pq)[len(*pq)-1]
	*pq = (*pq)[:len(*pq)-1]
	return item
}
