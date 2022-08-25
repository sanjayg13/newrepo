#include<iostream>
#include<list>
#include<algorithm>
using namespace std;

class CA
{
private:
	int a, b;
public:
	CA(int x = 0, int y = 0) :a(x), b(y) { }
	~CA() { }
	CA(const CA &x) :a(x.a), b(x.b) {	}
	void print()const { cout << "a=" << a << ",b=" << b << endl; }
	void operator()(CA &x) 
	{ 
		cout << "operator() called" << endl;
		cout << "a=" << x.a << ",b=" <<x.b << endl; 
	}
};
//-----------------------
//GLOBAL FUNCTION
void Print(CA &x)
{
	x.print();   //now a call to class member function
}

int main()
{
	list<CA> ls1;
	//populate the list
	for (int i = 1; i <= 5; i++)
	{
		ls1.push_back(CA(i, i + 20));
	}
	//---------------
	/*list<CA>::iterator itr = ls1.begin();
	while (itr != ls1.end())
	{
		itr->print();
		itr++;
	}*/
	//---------------
	//one line code to achieve the same
	//for_each(ls1.begin(), ls1.end(), Print);
	
	//The above for_each is expensive, calls 2 functions
	//The one below is better, as it only calls 1 function - FUNCTOR
	CA obj1;
	for_each(ls1.begin(), ls1.end(), obj1);
	return 0;
}