#include<iostream>
using namespace std;
//an example on generic function supporting more than one datatype.

template<typename T1, typename T2>  void Add(T1 a, T2 b)
{
	cout << "data type of a is " << typeid(T1).name() << endl;
	cout << "data type of b is " << typeid(T2).name() << endl;
	cout << "sum is :" << a + b << endl;
}

//---consumer code-----
int main()
{
	Add(45.12f, 87.32);
	Add(66.90, 200);
	//The above generic function is also a candidate for homogenous inputs
	Add(400, 500);
	return 0;
}