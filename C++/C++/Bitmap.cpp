#include "Bitmap.hpp"

BitMap::BitMap(int num) :n(num), mask(0x1F), shift(5), pos(1 << mask), a(1 + n / 32, 0) {}

void BitMap::set(int i){
	a[i >> shift] |= (pos >> (i & mask));
}
int BitMap::get(int i){
	return a[i >> shift] & (pos >> (i & mask));
}
void BitMap::clr(int i){
	a[i >> shift] &= ~(pos >> (i & mask));
}