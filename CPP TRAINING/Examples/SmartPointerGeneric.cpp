#include<iostream>
using namespace std;
//An example on a GENERIC SMARTPOINTER CLASS

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

class CB
{
private:
	int a, b;
public:
	CB(int x = 0, int y = 0) :a(x), b(y) { cout << "CB constructor" << endl; }
	~CB() { cout << "CB destructor" << endl; }
	void print() { cout << "a=" << a << ",b=" << b << endl; }
};


/*
-A Wrapper class that facilitates or manages the heap instances of
any class kind without the consumer having to use the new/delete functions
*/
template<typename T> class Smartpointer
{
private:
	T* p;     // PIMPL --> Pointer implementation model
public:
	//RAII - Resource acquisition is initialization
	Smartpointer(int x = 0, int y = 0)
	{
		p = new(nothrow) T(x, y);
	}
	~Smartpointer()
	{
		if (p != NULL)
			delete p;
	}
	//----------------
	void print() { p->print(); }
	//--custom copy constructor - DEEP COPY, avoids dangling pointer
	Smartpointer(const Smartpointer &x)
	{
		p = new(nothrow) T(*(x.p));
	}
	//-- custom assignment function - DEEP ASSIGNMENT, avoids mem. leak
	Smartpointer& operator =(Smartpointer &x)
	{
		*(this->p) = *(x.p);
		return *this;
	}
	//Smartpointers-----
	T* operator ->()
	{
		cout << "operator ->() called" << endl;
		return p;
	}
	T* operator &()
	{
		cout << "operator &() called" << endl;
		return p;
	}
	T& operator *()
	{
		cout << "operator*() called" << endl;
		return *p;
	}

};
//-----------consumer code-------------
int main()
{
	Smartpointer<CA> obj1(10, 20);
	obj1.print();

	Smartpointer<CB> obj2(30, 40);
	obj2.print();

	Smartpointer<CA> obj3(obj1);
	obj3->print();

	Smartpointer<CB> obj4;
	obj4 = obj2;
	(*obj4).print();
	return 0;
}