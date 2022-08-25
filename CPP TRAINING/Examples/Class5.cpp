#include<iostream>
using namespace std;

class CA
{
private:
	int a, b;
public:
	CA();
	CA(int);
	CA(int, int);
	void input();
	void print();
};
//place the declarations outside the class body
CA::CA()
{
	cout << "CA default constructor" << endl;
	a = 0;
	b = 0;
}
CA::CA(int x)
{
	cout << "CA one arg. constructor" << endl;
	a = x;
	b = x;
}

CA::CA(int x, int y)
{
	cout << "CA two arg. constructor" << endl;
	a = x;
	b = y;
}
void CA::input()
{
	cout << "enter 2 nos." << endl;
	cin >> this->a >> this->b;
}
void CA::print()
{
	cout << "a =" << this->a << "b=" << this->b << endl;
}

//---consumer code-----
int main()
{
	CA obj1,obj2(100),obj3(20,30);   //local objects reside on stack
	obj1.print();
	obj2.print();
	obj3.print();
	return 0;
}