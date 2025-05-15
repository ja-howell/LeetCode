package main

import "fmt"

func main() {
	words := []string{"e", "a", "b"}
	groups := []int{0, 0, 1}

	fmt.Println(getLongestSubsequence(words, groups))

}

func getLongestSubsequence(words []string, groups []int) []string {
	wordsSubsequence := []string{}
	lastVal := -1

	for i, val := range groups {
		if val != lastVal {
			wordsSubsequence = append(wordsSubsequence, words[i])
			lastVal = val
		}
	}
	return wordsSubsequence
}
