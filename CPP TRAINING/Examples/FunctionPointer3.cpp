#include<iostream>
using namespace std;

class CA
{
public:
	void fun1() { cout << "CA-fun1 called" << endl; }
	void fun2() { cout << "CA-fun2 called" << endl; }
	static void fun3() { cout << "CA-fun3 static method called" << endl; }
};

int main()
{
	void(CA::*fp)() = &CA::fun1;
	CA obj1;
	(obj1.*fp)();
	cout << "-----------------" << endl;
	fp = &CA::fun2;
	CA* p = new(nothrow) CA;
	(p->*fp)();
	delete p;
	//----function pointer that can hold static member function address
	void(*ff)();
	ff = &CA::fun3;
	(*ff)();
	return 0;
}