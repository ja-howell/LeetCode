package main

import (
	"fmt"
)

func main() {
	fmt.Println(reverseVowels("Ajje"))
}

func reverseVowels(s string) string {
	vowelMap := map[byte]struct{}{
		'a': {},
		'e': {},
		'i': {},
		'o': {},
		'u': {},
		'A': {},
		'E': {},
		'I': {},
		'O': {},
		'U': {},
	}

	vowels := []byte{}
	newS := []byte(s)
	//traverse backwards and throw the rune unto a stack

	for i := len(s) - 1; i >= 0; i-- {
		_, ok := vowelMap[s[i]]
		if ok {
			vowels = append(vowels, s[i])
		}
	}
	//Replace with vowels from stack
	pop := 0
	for i := range s {
		_, ok := vowelMap[s[i]]
		if ok {
			newS[i] = vowels[pop]
			pop++
		} else {
			newS[i] = s[i]
		}
	}

	return string(newS)
}
