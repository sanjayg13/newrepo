#include<iostream>
using namespace std;
//An example on deep copy/deep assignment

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
	//--custom copy constructor - DEEP COPY, avoids dangling pointer
	CB(const CB &x)
	{
		p = new(nothrow) CA(*(x.p));
	}
	//-- custom assignment function - DEEP ASSIGNMENT, avoids mem. leak
	CB& operator =(CB &x)
	{
		*(this->p) = *(x.p);
		return *this;
	}
    //Smartpointers-----
	CA* operator ->()
	{
		cout << "operator ->() called" << endl;
		return p;
	}
	CA* operator &()
	{
		cout << "operator &() called" << endl;
		return p;
	}
	CA& operator *()
	{
		cout << "operator*() called" << endl;
		return *p;
	}

};
//-----------consumer code-------------
int main()
{
	CB obj1(10, 20);
	CA *q = &obj1;   // CA* q = obj1.operator &();
	obj1->print();   // (obj1.operator ->())->print();
	(*obj1).print();  // (obj1.operator *()).print();
	return 0;
}