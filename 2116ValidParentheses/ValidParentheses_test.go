package main

import (
	"log"
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestCanBeValid(t *testing.T) {
	tests := []struct {
		input    string
		locked   string
		expected bool
	}{
		{"))()))", "010100", true},
		{"()()", "0000", true},
		{")", "0", false},
		{"())()))()(()(((())(()()))))((((()())(())", "1011101100010001001011000000110010100101", true},
		{"())(()(()(())()())(())((())(()())((())))))(((((((())(()))))(", "100011110110011011010111100111011101111110000101001101001111", false},
	}
	for i, test := range tests {
		log.Println(i)
		assert := assert.New(t)
		got := canBeValid(test.input, test.locked)
		assert.Equal(test.expected, got)
	}

}
