#include<iostream>
using namespace std;
//An example on generic function/function template, supporting a
//single unknown datatype.

template<typename T> void Add(T x, T y)
{
	T z;
	z = z + y;
	cout << "sum is " << z << endl;
}

int main()
{
	Add(10, 20);
	Add(12.34f, 67.32f);
	Add(84.77, 59.93);
	return 0;
}