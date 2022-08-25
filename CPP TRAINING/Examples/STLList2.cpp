#include<iostream>
#include<list>
using namespace std;

class CA
{
private:
	int a, b;
public:
	CA(int x = 0, int y = 0) :a(x), b(y) { cout << "CA constructor" << endl; }
	~CA() { cout << "CA destructor" << endl; }
	CA(const CA &x):a(x.a),b(x.b)
	{
		cout << "CA copy constructor" << endl;
	}
	void print()const { cout << "a=" << a << ",b=" << b << endl; }
};

//--------class consumer-------------
int main()
{
	list<CA> ls1;
	//populate the list with few CA objects
	for (int i = 1; i <= 10; i++)
	{
		ls1.push_back(CA(i, i + 10));
	}

	list<CA>::iterator itr = ls1.begin();
	while (itr != ls1.end())
	{
		itr->print();    // (itr.operator ->())->print();
		itr++;
	}
	return 0;
}