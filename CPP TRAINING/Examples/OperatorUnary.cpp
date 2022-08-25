#include<iostream>
using namespace std;
//an example on unary operator overloading.
class CA
{
private:
	int a, b;
public:
	CA(int = 0, int = 0);
	void print() const;
	CA& operator ++();    //PREFIX
	CA operator ++(int);  // POSTFIX
};

CA::CA(int x, int y) :a(x), b(y) { }

void CA::print() const { cout << "a=" << a << ",b=" << b << endl; }

CA& CA::operator ++()
{
	cout << "operator ++ PREFIX" << endl;
	++this->a;
	++this->b;
	return *this;
}

CA CA::operator ++(int)
{
	cout << "operator ++ POSTFIX" << endl;
	CA temp(*this);  //backup the value before incrementing
	//now increment it
	this->a++;
	this->b++;
	//return the old value
	return temp;
}
//----------class consumer code--------
int main()
{
	CA obj1(10, 20), obj2(10, 20);
	CA prefix, postfix;
	prefix = ++obj1;   // prefix = obj1.operator ++();
	obj1.print();
	prefix.print();
	cout << "------------" << endl;
	postfix = obj2++;  // postfix = obj2.operator ++(int);
	obj2.print();
	postfix.print();
	return 0;
}