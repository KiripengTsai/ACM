package db

import "log"

type auth struct {
	Id       uint   `json:"id"`
	UserName string `json:"username"`
}

var (
	userId   uint
	userName string
)

func GetAuth() []auth {

	Auth := make([]auth, 0)

	rows, err := dbConn.Query("select id,username from blog_auth")

	if err != nil {
		log.Fatalf("select data error:%v", err)
	}

	for rows.Next() {
		rows.Scan(&userId, &userName)
		if err != nil {
			log.Fatal(err)
		}
		data := auth{userId, userName}
		Auth = append(Auth, data)
	}

	return Auth
}
