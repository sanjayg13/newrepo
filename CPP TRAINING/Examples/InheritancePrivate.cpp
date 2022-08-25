#include<iostream>
using namespace std;
//An example on inheritance and the role of 'private' access specifier.

class CA
{
private:
	int a,b;
public:
	void input()
	{
		cout <<"CA-input, enter 2 nos" << endl;
		cin >> a >> b;
	}
	void print()
	{
		cout <<"CA-print, a = " << a <<",b=" << b << endl;
	}
};
//********************
class CB:private CA
{
public:
	void input()
	{
		cout <<"CB-input, enter 2 nos" << endl;
		cin >> a >> b;
	}
	void print()
	{
		cout <<"CB-print, a = " << a <<",b=" << b << endl;
	}
};
//******consumer code************
void main()
{
	cout <<"size of CB " << sizeof(CB) << endl;
	CB obj1;
	obj1.input();
	obj1.print();
}