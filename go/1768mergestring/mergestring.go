package main

import (
	"fmt"
	"strings"
)

func main() {
	fmt.Println(mergeAlternately("abchgvv", "pqrrs"))
}

func mergeAlternately(word1 string, word2 string) string {
	sb := strings.Builder{}
	s := min(len(word1), len(word2))

	for i := 0; i < s; i++ {
		sb.WriteByte(word1[i])
		sb.WriteByte(word2[i])
	}
	sb.WriteString(word1[s:])
	sb.WriteString(word2[s:])
	return sb.String()
}
