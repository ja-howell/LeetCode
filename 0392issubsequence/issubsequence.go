package main

import "fmt"

func main() {
	s := "aza"
	t := "abzba"

	fmt.Println(isSubsequence(s, t))
}

func isSubsequence(s string, t string) bool {
	if s == t {
		return true
	}
	tIndex := -1
	sequenceLength := 0
	for _, let := range s {
		letFound := false
		for i := tIndex + 1; i < len(t); i++ {
			if let == rune(t[i]) {
				tIndex = i
				letFound = true
				sequenceLength++
				break
			}
		}
		if !letFound {
			return false
		}
	}
	return sequenceLength <= len(s)
}
