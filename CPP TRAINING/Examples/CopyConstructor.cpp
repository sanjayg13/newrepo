#include<iostream>
using namespace std;
/*
	An example on copy constructor, A constructor which takes an 
	object of its own kind by reference as parameter.
*/
class CA
{
private:
	int a,b;
public:
	CA();
	CA(int);
	CA(int, int);
	void input();
	void print();
	~CA();
	CA(CA &);
};
//place the declarations outside the class body

CA::CA() :a(0), b(0)
{
	cout << "CA default constructor" << endl;
}

CA::CA(int x) : a(x), b(x)
{
	cout << "CA one arg. constructor" << endl;
}

CA::CA(int x, int y) : a(x), b(y)
{
	cout << "CA two arg. constructor" << endl;
}

void CA::input()
{
	cout << "enter 2 nos." << endl;
	//cin >> this->a >> this->b;
}
void CA::print()
{
	cout << "a =" << this->a << "b=" << this->b << endl;
}
CA::~CA() { cout << "CA destructor called" << endl; }
CA::CA(CA &x) :a(x.a), b(x.b)
{
	cout << "CA copy constructor" << endl;
}
//---consumer code-----
int main()
{
	CA obj1(20, 30);   //local objects reside on stack
	obj1.print();

	CA obj2(obj1);  // demands copy constructor
	obj2.print();
	return 0;
}