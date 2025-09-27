package main

import "fmt"

func main() {
	board := []string{"XX", "O."}
	fmt.Println(solution(board))
}

func solution(board []string) string {

	// Check rows
	for _, row := range board {
		isEqual := true

		for i := 0; i < len(row)-1; i++ {
			if row[i] == '.' || row[i] != row[i+1] {
				isEqual = false
			}
		}
		if isEqual {
			return string(row[i]) + " WINS"
		}
	}

	// Check columns
	for i := 0; i < len(board)-1; i++ {
		isEqual := true
		for index, row := range board {
			if row[i] == '.' || row[i] != board[index+1][i] {
				isEqual = false
			}
		}
		if isEqual {
			return string(board[i]) + " WINS"
		}
	}

	index := 0
	isEqual := true
	for index < len(board)-1 {
	}

	return "ONGOING"
}
