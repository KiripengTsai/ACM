#include<iostream>
#include"Bitmap.hpp"
using namespace std;

int main() {
	BitMap bitMap(5);
	bitMap.set(1);
	cout<<bitMap.get(1);
	return 0;
}