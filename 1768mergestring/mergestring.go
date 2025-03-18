package main

import (
	"fmt"
	"strings"
)

func main() {
	fmt.Println(mergeAlternately("abc", "pqr"))
}

func mergeAlternately(word1 string, word2 string) string {
	sb := strings.Builder{}
	if len(word1) >= len(word2) {
		for i := range word1 {
			sb.WriteByte(word1[i])
			if i < len(word2) {
				sb.WriteByte(word2[i])
			}
		}
	} else {
		for i := range word2 {
			if i < len(word1) {
				sb.WriteByte(word1[i])
			}
			sb.WriteByte(word2[i])
		}
	}
	return sb.String()
}
