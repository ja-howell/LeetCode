package main

import (
	"fmt"
)

const (
	left  byte = '('
	right byte = ')'
)

func main() {
	s := "))()))"
	locked := "010100"
	fmt.Println(canBeValid(s, locked))
}

func canBeValid(s string, locked string) bool {
	if len(s)%2 == 1 {
		return false
	}
	//indices of unlocked parens and open parens
	unlocked := []int{}
	leftParens := []int{}
	for i := 0; i < len(s); i++ {
		if locked[i] == '0' {
			unlocked = append(unlocked, i)
		} else if s[i] == left {
			leftParens = append(leftParens, i)
		} else if s[i] == right {
			if len(leftParens) > 0 {
				leftParens = leftParens[:len(leftParens)-1]
			} else if len(unlocked) > 0 {
				unlocked = unlocked[:len(unlocked)-1]
			} else {
				return false
			}
		}
	}

	for len(leftParens) > 0 && len(unlocked) > 0 && leftParens[len(leftParens)-1] < unlocked[len(unlocked)-1] {
		leftParens = leftParens[:len(leftParens)-1]
		unlocked = unlocked[:len(unlocked)-1]
	}

	return !(len(leftParens) > 0)
}
