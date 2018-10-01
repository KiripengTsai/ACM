package main

import "fmt"

type  Node struct{
	key interface{}
	next *Node
}

type Link struct {
	root *Node
}
type linkMethod interface {
	addValue(value interface{})
	findValue(value interface{})*Node
	print()
	getSize()uint64
}
func (link *Link) addValue(value interface{}){
	root:=link.root
	if root==nil{
		next:=Node{key:value}
		link.root=&next
		return
	}
	for root.next!=nil{
	     root=root.next
	}
	next:=Node{key:value}
	root.next=&next
}
func (link Link) findValue(value interface{})*Node{
	if link.root==nil{
		return nil
	}
	root:=link.root
	for root!=nil{
		if root.key==value{
			return root
		}
		root=root.next
	}
	return nil
}
func (link Link) print(){
	root:=link.root
	for root!=nil{
		fmt.Print(root.key," ")
		root=root.next
	}
}
func (link Link)getSize()uint64{
	 root:=link.root
	 var size uint64=0
	 for root!=nil{
	 	size++
	 	root=root.next
	 }
	 return size
}
func main(){
	link:=Link{root:nil}
	link.addValue(5)
	link.addValue(56)
	link.addValue(2)
	link.addValue(6)
	link.print()

}
