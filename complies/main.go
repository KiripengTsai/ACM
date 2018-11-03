package main

import (
	"bufio"
	"fmt"
	"io"
	"os"
)

var key = make(map[string]int)

var (
	FileName = "main.cpp"

	InputFile *os.File

	InputError error
	status     = false
)

//初始化,特征序
func keyInit() {
	key["if"] = 1
	key["int"] = 1
	key["for"] = 1
	key["while"] = 1
	key["do"] = 1
	key["return"] = 1
	key["break"] = 1
	key["continue"] = 1
	key["main"] = 2
	key["("] = 5
	key[")"] = 5
	key["{"] = 5
	key["}"] = 5
	key[","] = 5
	key["="] = 4
	key["+"] = 4
	key["-"] = 4
	key["*"] = 4
	key["/"] = 4
	key[";"] = 5
	key[">"] = 4
	key["<"] = 4
}

func main() {

	InputFile, InputError = os.OpenFile(FileName, os.O_RDWR, 0644)

	if InputError != nil {
		fmt.Println("Error")
		return
	}
	defer InputFile.Close()

	inputReader := bufio.NewReader(InputFile)

	//初始化
	keyInit()

	judgeMent()

	for {
		inputString, readerError := inputReader.ReadString('\n') //我们将inputReader里面的字符串按行进行读取。
		judgeToken(inputString)
		if readerError == io.EOF {
			return
		}
	}

}

func judgeMent() {
	InputFile, InputError = os.OpenFile(FileName, os.O_RDWR, 0644)
	defer InputFile.Close()
	inputReader := bufio.NewReader(InputFile)
	status := make([]uint8, 0, 0)
	for {
		inputString, readerError := inputReader.ReadByte() //我们将inputReader里面的字符串按行进行读取。
		if inputString == uint8('(') || inputString == uint8('{') {
			status = append(status, inputString)
		} else if (inputString == uint8(')') && status[len(status)-1] == uint8('(')) || (inputString == uint8('}') && status[len(status)-1] == uint8('{')) {
			status = append(status[:len(status)-1])
		}
		if readerError == io.EOF {
			break
		}
	}
	if len(status) != 0 {
		panic("符号不匹配")
	}
}

func judgeToken(line string) {

	token := ""

	for i := 0; i < len(line); i++ {

		if status {
			if i+1 < len(line) && line[i] == uint8('*') && line[i+1] == uint8('/') {
				status = false
				i++
			}
			continue
		}

		if i+1 < len(line) && line[i] == uint8('/') && line[i+1] == uint8('/') {
			break
		} else if i+1 < len(line) && line[i] == uint8('/') && line[i+1] == uint8('*') {
			status = true
			i++
			continue
		}

		if isLetter(line[i]) {
			token += string(line[i])

			//得到关键字
			if _, ok := key[token]; ok && !isLetter(line[i+1]) && !isNumber(line[i+1]) {
				Display(key[token], token)
				token = ""
			}
		} else if line[i] == uint8('(') || line[i] == uint8(')') {
			Display(key[string(line[i])], string(line[i]))
		} else if line[i] == uint8('{') || line[i] == uint8('}') {
			Display(key[string(line[i])], string(line[i]))
		} else if (line[i] == uint8(' ') || line[i] == uint8('\n')) && token != "" {
			if token[0] == uint8('-') && isNumber(token[1]) || isNumber(token[0]) {
				Display(3, token)
			} else {
				Display(2, token)
			}
			token = ""
		} else if line[i] == uint8(',') {
			Display(2, token)
			token = ""
			Display(key[string(line[i])], string(line[i]))
		} else if isOperation(line[i]) || line[i] == uint8(';') { //处理操作符号前面的类型
			if token != "" {
				if _, ok := key[token]; ok {
					Display(key[token], token)
				} else {
					if token[0] == uint8('-') && isNumber(token[1]) || isNumber(token[0]) {
						Display(3, token)
					} else {
						Display(2, token)
					}
				}
				token = ""
			}
			//得到/=，*=，+=，-=
			if isOperation(line[i]) {
				if line[i+1] == '=' {
					Display(4, string(line[i])+string(line[i+1]))
					i++
				} else {
					Display(key[string(line[i])], string(line[i]))
				}
				if line[i+1] == '-' {
					token += string(line[i+1])
					Display(key[string(line[i])], string(line[i]))
					i++
				}
			} else {
				Display(key[string(line[i])], string(line[i]))
			}

		} else if isNumber(line[i]) {
			token += string(line[i])
			if line[i+1] == uint8('.') && isNumberString(token) {
				token += string(line[i+1])
				i++
			}
			if line[i+1] == uint8('E') {
				token += string(line[i+1])
				i++
				if line[i+1] == uint8('-') {
					token += string(line[i+1])
					i++
				}
			}
		}
	}

}

//确定得到的token是整数类型
func isNumber(token uint8) bool {
	if token <= uint8('9') && token >= uint8('0') {
		return true
	}
	return false
}

//确定是范围内a-z或者A-Z

func isLetter(token uint8) bool {
	if (token <= uint8('z') && token >= uint8('a')) || (token <= uint8('Z') && token >= uint8('A')) {
		return true
	}
	return false
}

//提取格式 fmt.Printf("(%d,\"%s\")\n", key[string(line[i])], string(line[i]))
func Display(value int, key string) {
	fmt.Printf("(%d,\"%s\")\n", value, key)
}

//确保是操作符号
func isOperation(token uint8) bool {
	if token == uint8('/') || token == uint8('*') || token == uint8('+') || token == uint8('-') || token == uint8('=') {
		return true
	}
	if token == uint8('>') || token == uint8('<') || token == uint8('=') {
		return true
	}
	return false
}

func isNumberString(token string) bool {
	for i := 0; i < len(token); i++ {
		if !isNumber(token[i]) {
			return false
		}
	}
	return true
}
