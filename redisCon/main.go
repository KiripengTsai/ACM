package main

import (
	"fmt"
	"github.com/garyburd/redigo/redis"
)

func main() {
	c, err := redis.Dial("tcp", "111.230.250.88:6379")
	if err != nil {
		fmt.Println("Connect to redis error", err)
		return
	}
	defer c.Close()
}
