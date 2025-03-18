package main

import (
	"fmt"
	"slices"
	"strings"
)

func main() {
	s := "This is a test  "
	fmt.Println(reverseWords(s))

}

func reverseWords(s string) string {
	words := strings.Fields(s)
	if len(words) == 1 {
		return words[0]
	}

	sb := strings.Builder{}
	slices.Reverse(words)
	for i, word := range words {
		sb.WriteString(word)
		if i < len(words)-1 {
			sb.WriteString(" ")
		}
	}

	return sb.String()
}
