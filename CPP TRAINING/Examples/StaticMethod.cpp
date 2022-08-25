#include<iostream>
using namespace std;
//An example on static data and static method

class CA
{
private:
	int a;
	static int b;
public:
	CA(int = 0);
	void print() const;
	static void count();
};

//define memory for the static data well before we create objects
int CA::b;

//-------------------------
CA::CA(int x) :a(x)
{
	b = b + 1;
}

void CA::print() const { cout << "a=" << a << ",b=" << b << endl; }
void CA::count() { cout << "total objects:" << b << endl; }

//--- consumer code -----
int main()
{
	CA obj1(100), obj2(200), obj3(300);
	//obj1.print();
	//obj2.print();
	//obj3.print();
	//obj1.count();
	//obj2.count();
	//obj3.count();
	CA::count();
	return 0;
}