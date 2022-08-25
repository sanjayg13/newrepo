#include<iostream>
using namespace std;
//an example on reference type

void swap1(int*, int*);
void swap2(int&, int&);

int main()
{
	int a = 10, b = 20;
	//swap1(&a, &b);
	swap2(a, b);
	cout << "After swap, a=" << a << ",b=" << b << endl;
	return 0;
}

void swap1(int* p, int* q)  // int* p =&a;  int*q =&b;  call by address
{
	int temp = *p;
	*p = *q;
	*q = temp;
}
void swap2(int& p, int& q)  // int& p = a;  int& q = b; call by reference
{
	int temp = p;
	p = q;
	q = temp;
}