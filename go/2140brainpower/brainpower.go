package main

import "fmt"

func main() {
	questions := [][]int{
		{3, 2},
		{4, 3},
		{4, 4},
		{2, 5},
	}

	fmt.Println(mostPoints(questions))
}

func mostPoints(questions [][]int) int64 {
	maxPoints := int64(0)
	questionPointMap := make(map[int]int64, len(questions))

	for index := len(questions) - 1; index >= 0; index-- {
		questionMaxPoints := calcMaxPoints(questionPointMap, questions, index)
		if questionMaxPoints > maxPoints {
			maxPoints = questionMaxPoints
		}
		questionPointMap[index] = maxPoints
	}

	return maxPoints
}

func calcMaxPoints(questionPointMap map[int]int64, questions [][]int, index int) int64 {
	if index >= len(questions) {
		return 0
	}
	_, ok := questionPointMap[index]
	if ok {
		return questionPointMap[index]
	}
	points := int64(questions[index][0])
	questionPointMap[index] = calcMaxPoints(questionPointMap, questions, index+questions[index][1]+1) + points

	return questionPointMap[index]
}
