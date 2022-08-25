#include<iostream>
using namespace std;
//An example on shallow copy/shallow assignment

//Assumed to be a memory expensive class
class CA
{
private:
	int a, b;
public:
	CA(int x = 0, int y = 0) :a(x), b(y) { cout << "CA constructor" << endl; }
	~CA() { cout << "CA destructor" << endl; }
	void print() { cout << "a=" << a << ",b=" << b << endl; }
};

/*
 -A Wrapper class that facilitates or manages the heap instances of 
   CA kind without the consumer having to use the new/delete functions
*/
class CB
{
private:
	CA* p;     // PIMPL --> Pointer implementation model
public:
	//RAII - Resource acquisition is initialization
	CB(int x = 0, int y = 0)
	{
		p = new(nothrow) CA(x, y);
	}
	~CB()
	{
		if (p != NULL)
			delete p;
	}
	//----------------
	void print() { p->print(); }
};
//-----------consumer code-------------
int main()
{
	CB obj1(10, 20);
	obj1.print();
	CB obj2(obj1);  //demands copy constructor
	obj2.print();
	return 0;
}