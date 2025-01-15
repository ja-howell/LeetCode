package main

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestIsValid(t *testing.T) {
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
	for _, test := range tests {
		assert := assert.New(t)
		got := isValid(test.input, test.locked, 0)
		assert.Equal(test.expected, got)
	}

}
