package main

import (
	"fmt"
	"strings"
)

func main() {
	text := "hello world"
	brokenLetters := "ad"

	fmt.Println(canBeTypedWords(text, brokenLetters))
}

func canBeTypedWords(text string, brokenLetters string) int {
	numWords := 0
	for word := range strings.FieldsSeq(text) {
		if !strings.ContainsAny(word, brokenLetters) {
			numWords++
		}
	}
	return numWords
}
