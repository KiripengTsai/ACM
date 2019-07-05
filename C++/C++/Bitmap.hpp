#pragma once

#include<iostream>
#include<vector>
using namespace std;
class BitMap
{
public:
	BitMap(int num);
	void set(int i);
	int get(int i);
	void clr(int i);
private:
	int n;
	const int mask;
	const int shift;
	const unsigned int pos;
	std::vector<unsigned int> a;
};