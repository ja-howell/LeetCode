package main

import "fmt"

func main() {
	trie := Constructor()
	trie.Insert("app")
	fmt.Println(trie.nodes[0].letter)
	fmt.Println(trie.nodes[0].children[0].letter)
	fmt.Println(trie.nodes[0].children[0].children[0].letter)
	fmt.Println(trie.Search("app"))      // Output: true
	fmt.Println(trie.Search("appl"))     // Output: false
	fmt.Println(trie.StartsWith("ap"))   // Output: true
	fmt.Println(trie.StartsWith("appl")) // Output: false

}

type Trie struct {
	nodes []*Node
}

type Node struct {
	letter   string
	children []*Node
	isWord   bool
}

func Constructor() Trie {
	return Trie{}
}

func (this *Trie) Insert(word string) {
	//for each letter, check if it's in the path
	//if it is in the path go to that node and continue checking children until you can't find a letter
	//if a letter isn't in the path, create a new node with the letter, and then go to that node and repeat

	i, found := findLetter(this.nodes, string(word[0]))
	if found {
		this.nodes[i].insert(word[1:])
	} else {
		node := &Node{
			letter: string(word[0]),
		}
		node.insert(word[1:])
		this.nodes = append(this.nodes, node)
	}

}

func (this *Trie) Search(word string) bool {
	i, found := findLetter(this.nodes, string(word[0]))
	if !found {
		return false
	}
	return this.nodes[i].search(word[1:])
}

func (this *Trie) StartsWith(prefix string) bool {
	return this.Search(prefix)
}

func findLetter(nodes []*Node, letter string) (index int, found bool) {
	for i, node := range nodes {
		if node.letter == letter {
			return i, true
		}
	}
	return -1, false
}

func (n *Node) insert(word string) {
	if len(word) == 0 {
		return
	}
	i, found := findLetter(n.children, string(word[0]))
	if found {
		n.children[i].insert(word[1:])
		if len(word) == 1 {
			n.children[i].isWord = true
		}
	} else {
		node := &Node{
			letter: string(word[0]),
		}
		if len(word) == 1 {
			node.isWord = true
		}
		node.insert(word[1:])
		n.children = append(n.children, node)
	}
}

func (n *Node) search(word string) bool {
	if len(word) == 0 {
		return true
	}
	i, found := findLetter(n.children, string(word[0]))
	if !found {
		return false
	} else {
		return n.children[i].search(word[1:])
	}
}

/**
 * Your Trie object will be instantiated and called as such:
 * obj := Constructor();
 * obj.Insert(word);
 * param_2 := obj.Search(word);
 * param_3 := obj.StartsWith(prefix);
 */
