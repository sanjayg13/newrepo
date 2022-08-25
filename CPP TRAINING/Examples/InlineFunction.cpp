#include<iostream>
using namespace std;
//an example on inline function.

void Add(int, int);

int main()
{                    //Line 8 - PROLOG for main
	Add(10, 20);     // Line 9 - B.Logic for main
	return 0;
}                   //Line 11 - EPILOG for main

inline void Add(int x, int y)
{    //Line 14 - PROLOG for Add
	//cout << "sum =" << x + y << endl;   // Line 15 - B.Logic for Add
	cout << x << "+" << y << "=" << x + y << endl;
}    //Line 16 - EPILOG for Add

