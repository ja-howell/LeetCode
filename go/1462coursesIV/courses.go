package main

import (
	"fmt"
	"slices"
)

func main() {

	prerequisites := [][]int{
		{0, 3},
		{1, 2},
		{1, 0},
		{2, 0},
	}

	queries := [][]int{
		{1, 2},
		{1, 0},
	}

	responses := checkIfPrerequisite(0, prerequisites, queries)

	fmt.Println(responses)
}

type Node struct {
	neighbors   []int
	descendants []int
}

func checkIfPrerequisite(_ int, prerequisites [][]int, queries [][]int) []bool {

	courses := createCourseMap(prerequisites)
	printCourseMap(courses)

	responses := make([]bool, 0, len(queries))

	for _, query := range queries {
		a, b := query[0], query[1]
		if _, ok := courses[a]; ok {
			if slices.Contains(courses[a].descendants, b) {
				responses = append(responses, true)
			} else {
				responses = append(responses, false)
			}
		} else {
			responses = append(responses, false)
		}
	}

	return responses

}

func createCourseMap(prerequisites [][]int) map[int]*Node {
	courseDescendants := map[int]*Node{}

	for _, row := range prerequisites {
		a, b := row[0], row[1]
		_, ok := courseDescendants[a]
		if !ok {
			courseDescendants[a] = &Node{neighbors: []int{b}}
		} else {
			courseDescendants[a].neighbors = append(courseDescendants[a].neighbors, b)
		}
		if _, ok := courseDescendants[b]; !ok {
			courseDescendants[b] = &Node{}
		}
	}

	for course := range courseDescendants {
		courseDescendants[course].descendants = findDescendants(course, courseDescendants)
	}
	return courseDescendants
}

func findDescendants(key int, courseDescendants map[int]*Node) []int {
	fmt.Printf("course: %d neighbors: %v descendants: %v\n", key, courseDescendants[key].neighbors, courseDescendants[key].descendants)
	// if len(courseDescendants[key].neighbors) == 0 {
	// 	return []int{}
	// }
	//for each of the neighbors we haven't found yet

	//TODO switch to sets instead of slice for descendants
	for _, n := range courseDescendants[key].neighbors {
		fmt.Printf("current neighbor: %d\n", n)
		if !slices.Contains(courseDescendants[key].descendants, n) {
			courseDescendants[key].descendants = append(courseDescendants[key].descendants, n)
		}
		for _, desc := range findDescendants(n, courseDescendants) {
			if !slices.Contains(courseDescendants[key].descendants, desc) {
				courseDescendants[key].descendants = append(courseDescendants[key].descendants, desc)
			}
		}
	}
	return courseDescendants[key].descendants
}

func printCourseMap(courses map[int]*Node) {
	for k, s := range courses {
		fmt.Printf("%d: [ ", k)
		for _, v := range s.descendants {
			fmt.Printf("%d ", v)
		}
		fmt.Println("]")
	}
}
