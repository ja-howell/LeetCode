package main

import (
	"fmt"
)

const (
	left  byte = '('
	right byte = ')'
)

func main() {
	s := "())(()(()(())()())(())((())(()())((())))))(((((((())(()))))("
	locked := "100011110110011011010111100111011101111110000101001101001111"
	fmt.Println(canBeValid(s, locked))
}

func canBeValid(s string, locked string) bool {
	return isValid(s, locked, 0)
}

func isValid(parens string, locked string, depth int) bool {
	//It  doesn't go far enough back to track all possible flips
	// fmt.Printf("s: %v, locked: %v, depth: %v\n", parens, locked, depth)
	if parens == "" {
		return depth == 0
	}
	if depth == -1 {
		return false
	}

	valid := false
	if parens[0] == left {
		valid = isValid(parens[1:], locked[1:], depth+1)
		// fmt.Printf("valid: %v\ns: %v, locked: %v, depth: %v\n", valid, parens, locked, depth)
	} else {
		valid = isValid(parens[1:], locked[1:], depth-1)
	}
	if !valid && locked[0] == '0' {
		if parens[0] == left {
			valid = isValid(parens[1:], locked[1:], depth-1)
		} else {
			valid = isValid(parens[1:], locked[1:], depth+1)
		}
	}
	return valid
}
