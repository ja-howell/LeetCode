package main

import (
	"container/heap"
	"fmt"
)

func main() {

	nums := []int{2, 11, 10, 1, 3}
	k := 10

	fmt.Println(minOperations(nums, k))
}

func minOperations(nums []int, k int) int {
	minOps := 0

	numsHeap := Heap(nums)
	heap.Init(&numsHeap)

	for numsHeap[0] < k {
		x := heap.Pop(&numsHeap).(int)
		y := heap.Pop(&numsHeap).(int)
		heap.Push(&numsHeap, x*2+y)
		minOps++
	}

	return minOps
}

type Heap []int

func (h Heap) Len() int {
	return len(h)
}

func (h Heap) Less(i, j int) bool {
	return h[i] < h[j]
}

func (h Heap) Swap(i, j int) {
	h[i], h[j] = h[j], h[i]
}

func (h *Heap) Push(x any) {
	i := x.(int)
	*h = append(*h, i)
}

func (h *Heap) Pop() any {
	i := (*h)[len(*h)-1]
	*h = (*h)[:len(*h)-1]
	return i
}
