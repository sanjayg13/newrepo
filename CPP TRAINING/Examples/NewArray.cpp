#include<iostream>
using namespace std;
/*
prefer malloc/free for primitive types and C structs.

prefer new/delete for class objects, as new would facilitate implicit
invocation of an constructor call, and delete would facilitate implicit
invocation of destructor call.
*/
class CA
{
private:
	int a, b;
public:
	CA();
	explicit CA(int);
	CA(int, int);
	void print() const;
	~CA();
	CA(const CA &);
	CA* operator ->();
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

void CA::print() const
{
	cout << "a =" << this->a << "b=" << this->b << endl;
}
CA::~CA() { cout << "CA destructor called" << endl; }
CA::CA(const CA &x) :a(x.a), b(x.b)
{
	cout << "CA copy constructor" << endl;
}

CA* CA::operator ->()
{
	cout << "operator ->() called" << endl;
	return this;
}

//---consumer code-----
int main()
{
	//create an array of 5 CA instances on the heap
	CA* p = new(nothrow) CA[5];
	//business with the individual objects...
	p[0].print();
	p[1]->print();  // (p[1].operator ->())->print()
	//...

	//delete the array of instances pointed to by 'p'
	delete[] p;
	return 0;
}