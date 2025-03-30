package main

import (
	"fmt"
	"slices"
	"unicode"
)

func main() {
	s := "cb34"
	fmt.Println(clearDigits(s))
}

func clearDigits(s string) string {
	runeS := []rune(s)
	for i := 0; i < len(runeS); i++ {
		if unicode.IsDigit(runeS[i]) {
			runeS = slices.Delete(runeS, i-1, i+1)
			i = i - 2
		}
	}

	return string(runeS)
}
