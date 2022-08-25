#include<iostream>
using namespace std;
//an example on generic function supporting more than one datatype.

template<typename T1, typename T2, typename T3>  T3 Add(T1 a, T2 b)
{
	return a + b;
}

//---consumer code-----
int main()
{
	float x;
	x = Add<float, int,float>(12.34f, 100);
	cout << "x =" << x << endl;
	cout << "-------------" << endl;
	x = Add<int, float, float>(100, 12.34f);
	cout << "x =" << x << endl;
	return 0;
}