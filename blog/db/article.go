package db

var (
	id          int
	tag_id      int
	title       string
	desc        string
	context     string
	created_on  int
	created_by  string
	modified_on int
	modified_by string
	state       uint
)

func GetArticle(id int) map[string]interface{} {
	Information := make(map[string]interface{})

	stmCount, err := dbConn.Query("select id,tag_id,title,desc,context,created_on,created_by,modified_on,modified_by,state from blog_article where id=?", id)

	if err != nil {
		panic("运行sql查询id时出错")
	}

	stmCount.Scan(&id, &tag_id, &title, &desc, &context, &created_on, &created_by, &modified_on, &modified_by, &state)

	Information["id"] = id
	Information["tag_id"] = tag_id
	Information["desc"] = desc
	Information["context"] = context
	Information["created_on"] = created_on
	Information["created_by"] = created_by
	Information["modified_on"] = modified_on
	Information["modified_by"] = modified_by
	Information["state"] = state

	return Information
}
