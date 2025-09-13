package main

import "fmt"

func main() {
	fmt.Println(tribonacci(4))
}

func tribonacci(n int) int {
	if n <= 0 {
		return 0
	}
	if n <= 2 {
		return 1
	}

	return tribonacci(n-1) + tribonacci(n-2) + tribonacci(n-3)
}

func tribonacciDP(n int) int {
	dp := make([]int, n+1)
	dp[0] = 0
	dp[1] = 1
	dp[2] = 1
	for i := 3; i <= n; i++ {
		dp[i] = dp[i-1] + dp[i-2] + dp[i-3]
	}
	return dp[n]
}

func tribonacciOptimized(n int) int {
	if n <= 0 {
		return 0
	}
	a, b, c := 0, 1, 1
	for i := 3; i <= n; i++ {
		a, b, c = b, c, a+b+c
	}
	return c
}
