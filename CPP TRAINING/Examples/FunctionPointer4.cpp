#include<iostream>
using namespace std;

class CA
{
public:
	void fun1() { cout << "CA-fun1 called" << endl; }
	void fun2(void(CA::*ff)()) 
	{
		cout << "CA-fun2 called" << endl;
		(this->*ff)();
	}
};

int main()
{
	CA obj1;
	void(CA::*fp)() = &CA::fun1;
	obj1.fun2(fp);
	return 0;
}