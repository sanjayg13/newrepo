#include<iostream>
using namespace std;
//an example on function overloading
/*
	- Where one or more functions take the same name, subject to the
	  formal parameters are unique.
	- Overloading is not allowed based on uniqueness in return-types of
	  the function.
*/

void fun()   // in GCC   _Z3funv
{
	cout << __FUNCDNAME__ << endl;
	cout << "fun called" << endl;
}
void fun(int x)   // in GCC   _Z3funi
{
	cout << __FUNCDNAME__ << endl;
	cout << "fun(int x) called" << endl;
}
void fun(float x, double y)  // // in GCC   _Z3funfd
{
	cout << __FUNCDNAME__ << endl;
	cout << "fun(float x, double y) called" << endl;
}
//---consumer code----
int main()
{
	fun();
	fun(100);
	fun(12.34f, 67.98);
	return 0;
}