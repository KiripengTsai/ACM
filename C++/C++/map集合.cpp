#include<iostream>
#include<string>
#include<map>

using namespace std;
map<char, string> phraseMethod;

void InitPharseMethod() {
	phraseMethod['S'] = "prprogram";
	phraseMethod['A'] = "statement_list";
	phraseMethod['B'] = "statement";
	phraseMethod['C'] = "expression_stmt";
	phraseMethod['D'] = "if_stmt";
	phraseMethod['E'] = "while_stmt";
	phraseMethod['F'] = "expression";
	phraseMethod['G'] = "var";
	phraseMethod['H'] = "simple-expression";
	phraseMethod['J'] = "additive-expression";
	phraseMethod['K'] = "relop";
	phraseMethod['L'] = "addop";
	phraseMethod['M'] = "term";
	phraseMethod['N'] = "mulop";
	phraseMethod['P'] = "factor";
	phraseMethod['a'] = "main()";
	phraseMethod['b'] = "{";
	phraseMethod['c'] = "}";
	phraseMethod['d'] = ";";
	phraseMethod['e'] = "if";
	phraseMethod['f'] = "(";
	phraseMethod['g'] = ")";
	phraseMethod['h'] = "else";
	phraseMethod['j'] = "while";
	phraseMethod['k'] = "=";
	phraseMethod['m'] = "ID";
	phraseMethod['n'] = "[";
	phraseMethod['o'] = "]";
	phraseMethod['p'] = "<=|<|>|>=|==|!=";
	phraseMethod['r'] = "+|-";
	phraseMethod['s'] = "*|/";
	phraseMethod['t'] = "NUM";

}

/*
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
*/

/*
0. program->main() { statement_list }
   S->prprogram
   a->main()
   A->statement_list
   b->{
   c->}
0. S->abAc

1. statement_list->statement_list statement|$
   A->statement_list
   B->statement
1. A->AB|$

2. statement->expression_stmt|if_stmt|while_stmt
   B->statement
   C->expression_stmt
   D->if_stmt
   E->while_stmt
2. B->C|D|E

3. expression_stmt->expression;|;
   C->expression_stmt
   F->expression
   d->;
3. C->Fd|d

4. if_stmt->if ( expression ) statement | if ( expression ) statement else statement
   D->if_stmt
   e->if
   f->(
   F->expression
   g->)
   B->statement
   h->else
4. D->efFgB|efFgBhB

5. while-stmt-> while ( expression ) statement


5. E->jfFg

6. expression-> var = expression | simple-expression
   G->var
   k->=
6. F->GkF|H

7. var -> ID | ID [ expression ]
   m->ID
7. G->m|mnFo

8. simple-expression -> additive-expression relop additive-expression | additive-expression
  
8. H->JKJ|J

9. relop-><=|<|>|>=|==|!=

9. K->p

10. additive-expression -> additive-expression addop term | term

10. J->JLM|M

11. addop->+|-

11. L->r

12. term->term mulop factor | factor

12. M->MNP|P

13. mulop -> * | /

13.  N->s

14. factor -> ( expression ) | var | NUM

14  P->fFg|G|t
*/

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