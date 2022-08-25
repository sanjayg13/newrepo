#include<iostream>
using namespace std;
//An example on generic function/function template, supporting a
//single unknown datatype.

template<typename T> void Add(T x, T y)  //generic function
{
	T z;
	z = z + y;
	cout << "sum is " << z << endl;
}
//---- specialize the above generic function for CHAR type---
template<> void Add(char x, char y)  //type specific function
{
	cout << "The 2 characters cannot be added" << endl;
}

//------------------------

int main()
{
	Add(10, 20);
	Add(12.34f, 67.32f);
	Add(84.77, 59.93);
	//----------------------------
	Add('y', 'q');
	return 0;
}