package main

import (
	"database/sql"
	"fmt"
	"github.com/gin-gonic/gin"
	"github.com/go-ini/ini"
	"log"
	"net/http"

	_"github.com/go-sql-driver/mysql"
)

//返回从config返回的数据库信息，提供链接
func getDatabase() (ServerInformation string){
   Cfg,err:=ini.Load("example/config.ini")
   if err!=nil{
   	    log.Fatalf("Fail to parse 'conf/app.ini': %v", err)
   }
   //数据库链接的配置
   port:=Cfg.Section("database").Key("port").MustInt(3306)
   userName:=Cfg.Section("database").Key("username").MustString("root")
   userKey:=Cfg.Section("database").Key("userKey").MustString("123456")
   address:=Cfg.Section("database").Key("address").MustString("127.0.0.1")
   return fmt.Sprintf("%v:%v@tcp(%v:%v)/test?parseTime=true",userName,userKey,address,port)
}


func main() {
	db, err := sql.Open("mysql", getDatabase())
	if err != nil{
		log.Fatalln(err)
	}
	defer db.Close()


	db.SetMaxIdleConns(20)
	db.SetMaxOpenConns(20)

	if err := db.Ping(); err != nil{
		log.Fatalln(err)
	}

	router := gin.Default()
	router.GET("/", func(c *gin.Context) {
		c.String(http.StatusOK, "It works")
	})

	router.Run(":8000")


}


