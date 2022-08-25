#include<iostream>
using namespace std;
//an example on generic function supporting more than one datatype.

template<typename T1, typename T2, typename T3>  T1 Add(T2 a, T3 b)
{
	return a + b;
}

//---consumer code-----
int main()
{
	float x;
	x = Add<float>(12.34f, 100);   // implicit cum explicit instantiation
	cout << "x =" << x << endl;
	cout << "-------------" << endl;
	x = Add<float>(100, 12.34f);
	cout << "x =" << x << endl;
	return 0;
}