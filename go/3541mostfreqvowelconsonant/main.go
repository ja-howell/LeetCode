package main

import "fmt"

func main() {
	fmt.Println(maxFreqSum("successes"))

}

func maxFreqSum(s string) int {
	freqMap := findFreqs(s)
	maxVowel := 0
	maxCons := 0
	for key, val := range freqMap {
		if isVowel(key) && val > maxVowel {
			maxVowel = val
		}
		if isConsonant(key) && val > maxCons {
			maxCons = val
		}
	}
	return maxCons + maxVowel
}

func findFreqs(s string) map[rune]int {
	freqMap := map[rune]int{}
	for _, let := range s {
		freqMap[let]++
	}
	return freqMap
}

func isVowel(let rune) bool {
	if let == 'a' || let == 'e' || let == 'i' || let == 'o' || let == 'u' {
		return true
	}

	return false
}

func isConsonant(let rune) bool {
	return !isVowel(let)
}
