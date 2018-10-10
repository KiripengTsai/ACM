package main

import (
	"database/sql"
	"encoding/json"
	"fmt"
	_ "github.com/go-sql-driver/mysql"
	"log"
)

//处理json数据
type User struct {
	Id   int
	Name string
	Age  int
}

//操作数据库
func selectData(db *sql.DB) {
	var id int
	var name string
	var age int
	rows, err := db.Query(`SELECT id,name,age From user where name= ?`, `skikda`)
	if err != nil {
		log.Fatalf("insert data error: %v\n", err)
		return
	}
	for rows.Next() {
		rows.Scan(&id, &name, &age)
		if err != nil {
			log.Fatal(err)
		}
		log.Printf("get data, id: %d, name: %s, age: %d", id, name, age)
	}

	data := User{id, name, age}
	j, err := json.Marshal(data)
	if err != nil {
		log.Fatalf("Marshal Error %v", err)
		return
	}
	fmt.Println(string(j))

	err = rows.Err()
	if err != nil {
		log.Fatal(err)
	}
}

func main() {
	db, err := sql.Open("mysql",
		"user:password@tcp(127.0.0.1:3306)/test")
	if err != nil {
		log.Fatal(err)
	}
	selectData(db)
	defer db.Close()
}
