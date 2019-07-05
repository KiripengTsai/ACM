#include<iostream>
#include<vector>
#include<string>
#include<map>
#include<set>
#include<sstream>
#include<cctype>

using namespace std;

vector<vector<string>>          grammer;
map<char, set<char>>            firstList;
map<char, set<char>>            followList;

void processState(string str) {
	vector<string> temp;

	//temp.push_back();
	stringstream stream;
	stream << str[0];
	temp.push_back(stream.str());

	firstList[str[0]] = set<char>();
	followList[str[0]] = set<char>();

	if (str[0] == 'S') {
		followList[str[0]].insert('#');
	}

	str = str.substr(3) + "|";//S->a|b|c|d
	while (!str.empty()) {
		string temp_line = str.substr(0, str.find('|'));
		str = str.substr(str.find('|') + 1);

		temp.push_back(temp_line);
	}
	grammer.push_back(temp);

}

//初始化first集
void InitFirst() {
	bool isTrue = true;
	while (isTrue) {
		isTrue = false;
		for (int i = 0; i < grammer.size(); i++) {
			vector<string> temp = grammer[i];
			char nonterminal = temp[0][0];
			int size = firstList[nonterminal].size();
			for (int i = 1; i < temp.size(); i++) {

				if (islower(temp[i][0])) {
					firstList[nonterminal].insert(temp[i][0]);
				}

				if (isupper(temp[i][0])) {
					//firstList[nonterminal].insert(temp[i][0]);
					//将非终结符的first集加入
					for (auto j = firstList[temp[i][0]].begin(); j != firstList[temp[i][0]].end(); j++) {
						firstList[nonterminal].insert(*j);
					}
				}

			}
			if (size < firstList[nonterminal].size()) {
				isTrue = true;
			}

		}

	}

}

int FistAddFollow(char follow, char first) {
    
	set<char> temp_firstList = firstList[first];
	for (auto i =temp_firstList.begin(); i !=temp_firstList.end(); i++) {
		followList[follow].insert(*i);
	}
	return followList[follow].size();
}

int Follow1ToFollow2(char first, char last) {
	set<char> temp_firstList = followList[first];
	for (auto i = temp_firstList.begin(); i != temp_firstList.end(); i++) {
		followList[last].insert(*i);
	}
	return followList[last].size();
}

//初始化Follow集
void InitFollow() {
	bool isTrue = true;
	while (isTrue) {
		isTrue = false;
		for (int i = 0; i < grammer.size(); i++) {
			vector<string> temp = grammer[i];
			char nonterminal = temp[0][0];
			for (int j = 1; j < temp.size(); j++) {
				for (int k = 0; k < temp[j].size(); k++) {
					if (k + 1 < temp[j].size() && isupper(temp[j][k]) && isupper(temp[j][k + 1])) {
						int size = followList[temp[j][k]].size();
						int size_change = FistAddFollow(temp[j][k], temp[j][k + 1]);
						if (size != size_change) {
							isTrue = true;
						}
					}
					if (k + 1 < temp[j].size() && isupper(temp[j][k]) && islower(temp[j][k + 1])) {
						int size = followList[temp[j][k]].size();
						followList[temp[j][k]].insert(temp[j][k + 1]);
						int size_change = followList[temp[j][k]].size();
						if (size != size_change) {
							isTrue = true;
						}
					}
					if (k == temp[j].size() - 1 && isupper(temp[j][k])) {
						int size = followList[temp[j][k]].size();
						int size_change = Follow1ToFollow2(nonterminal, temp[j][k]);
						if (size != size_change) {
							isTrue = true;
						}
					}
				}
			}

			
		}

	}
}



int main() {
	int cnt;
	cout << "请输入指令条数";
	cin >> cnt;
	string line;
	
	for (int i = 0; i < cnt; i++) {
		cin >> line;
		processState(line);
	}

	for (int i = 0; i < grammer.size(); i++) {
		vector<string> temp= grammer[i];
		char nonterminal = temp[0][0];
		for (int i = 1; i < temp.size(); i++) {

			if (islower(temp[i][0])) {
				firstList[nonterminal].insert(temp[i][0]);
			}

		}
	}
	InitFirst();
	InitFollow();
	for (int i = 0; i < grammer.size();i++) {
		vector<string> temp = grammer[i];
		cout << temp[0][0] << "First:" << endl;
		for (auto j = firstList[temp[0][0]].begin(); j != firstList[temp[0][0]].end(); j++) {
			cout << *j << ' ';
		}
		cout <<endl<< temp[0][0] << "Follow:" << endl;
		for (auto j = followList[temp[0][0]].begin(); j != followList[temp[0][0]].end(); j++) {
			cout << *j << ' ';
		}
		cout << endl;
	}

     return 0;
}

/*
S->prprogram
A->statement_list
B->statement
C->expression_stmt
D->if_stmt
E->while_stmt
F->expression
G->var
H->simple-expression
J->additive-expression
K->relop
L->addop
M->term
N->mulop
P->factor

*/

/*
a->main()
b->{
c->}
d->;
e->if
f->(
g->)
h->else
j->while
k->=
m->ID
n->[
o->]
p-><=|<|>|>=|==|!=
r->+|-
s->*|/
t->NUM
*/

0.  S->abAc
1.  A->AB|$
2.  B->C|D|E
3.  C->Fd|d
4.  D->efFgB|efFgBhB
5.  E->jfFg
6.  F->GkF|H
7.  G->m|mnFo
8.  H->JKJ|J
9.  K->p
10. J->JLM|M
11. L->r
12. M->MNP|P
13. N->s
14. P->fFg|G|t