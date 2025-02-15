package main

func main() {
	//TODO explore 3rd party leetcode datastructures

}

type TreeNode struct {
	Val   int
	Left  *TreeNode
	Right *TreeNode
}

func lcaDeepestLeaves(root *TreeNode) *TreeNode {
	ancestor, _ := deepestLeaves(root, 0)
	return ancestor

}

func deepestLeaves(root *TreeNode, depth int) (ancestor *TreeNode, maxDepth int) {
	if root == nil {
		return nil, depth
	}
	if !hasChildren(root) {
		return root, depth + 1
	}

	depth++
	ancestorLeft, maxDepthLeft := deepestLeaves(root.Left, depth)
	ancestorRight, maxDepthRight := deepestLeaves(root.Right, depth)

	if maxDepthLeft > maxDepthRight {
		return ancestorLeft, maxDepthLeft
	} else if maxDepthLeft < maxDepthRight {
		return ancestorRight, maxDepthRight
	} else {
		return root, maxDepthLeft
	}

}

func hasChildren(root *TreeNode) bool {
	return root.Left != nil || root.Right != nil
}
