#include<iostream>
using namespace std;
/*
An example on const objects, const methods and const correctness
*/
class CA
{
private:
	int a, b;
public:
	CA();
	CA(int);
	CA(int, int);
	void input();
	void print() const;   //const method  --> void print(const CA*);
	void print();        //non-const method --> void print(CA* );
	~CA();
	CA(const CA &);
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
	cin >> this->a >> this->b;
}
void CA::print() const
{
	cout << "a =" << this->a << "b=" << this->b << endl;
}
void CA::print() 
{
	a = a + 10;
	b = b + 10;
	cout << "CA, non-const print, a =" << this->a << "b=" << this->b << endl;
}
CA::~CA() { cout << "CA destructor called" << endl; }
CA::CA(const CA &x) :a(x.a), b(x.b)
{
	cout << "CA copy constructor" << endl;
}
//---consumer code-----
int main()
{
	
	CA obj1(20, 30);   
	obj1.print();   
	
	const CA obj2(40, 50);
	obj2.print();
	return 0;
}