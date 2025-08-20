package main

func main() {
}

type LRUCache struct {
	capacity   int
	cacheMap   map[int]*Node
	head, tail *Node
}

type Node struct {
	prev, next *Node
	key, value int
}

func newNode(key, val int) *Node {
	return &Node{
		key:   key,
		value: val,
	}
}

func Constructor(capacity int) LRUCache {
	head, tail := newNode(0, 0), newNode(0, 0)
	head.next = tail
	tail.prev = head
	newCache := LRUCache{
		capacity: capacity,
		cacheMap: make(map[int]*Node),
		head:     head,
		tail:     tail,
	}
	return newCache
}

func (this *LRUCache) Get(key int) int {
	if node, ok := this.cacheMap[key]; ok {
		this.delete(node)
		this.add(node)
		return node.value
	}
	return -1
}

func (this *LRUCache) Put(key int, value int) {
	if node, ok := this.cacheMap[key]; ok {
		this.delete(node)
	}
	if len(this.cacheMap) == this.capacity {
		this.delete(this.tail.prev)
	}
	node := newNode(key, value)
	this.add(node)
}

func (this *LRUCache) delete(node *Node) {
	delete(this.cacheMap, node.key)
	node.prev.next = node.next
	node.next.prev = node.prev
}

func (this *LRUCache) add(node *Node) {
	this.cacheMap[node.key] = node
	node.prev = this.head
	node.next = this.head.next
	this.head.next = node
	node.next.prev = node

}

/**
 * Your LRUCache object will be instantiated and called as such:
 * obj := Constructor(capacity);
 * param_1 := obj.Get(key);
 * obj.Put(key,value);
 */
