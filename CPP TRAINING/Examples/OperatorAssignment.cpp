#include<iostream>
using namespace std;
//an example on assignment operator overloading.
class CA
{
private:
	int a, b;
public:
	CA(int = 0, int = 0);
	void print() const;
	CA& operator =(CA &x);
};

CA::CA(int x, int y) :a(x), b(y) { }

void CA::print() const { cout << "a=" << a << ",b=" << b << endl; }
CA& CA::operator =(CA &x)
{
	cout << "operator = called" << endl;
	this->a = x.a;
	this->b = x.b;
	return *this;
}
//---consumer code-----
int main()
{
	CA obj1(10, 20);
	CA result;
	//result = obj1;        // result.operator =(obj1);
	//result.print();
	CA obj2;
	result = obj2 = obj1;
	         // result.operator =(obj2.operator =(obj1));
	obj2.print();
	result.print();
	return 0;
}