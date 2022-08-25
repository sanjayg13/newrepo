#include<iostream>
using namespace std;
//an example on NAMING CONVENTION


//void fun()   
//void __cdecl fun() 
//extern "C++" void __cdecl fun() 
extern "C" void  __cdecl  fun() 
{
	cout << __FUNCDNAME__ << endl;
	cout << "fun called" << endl;
}

int main()
{
	cout << __FUNCDNAME__ << endl;
	fun();
	return 0;
}