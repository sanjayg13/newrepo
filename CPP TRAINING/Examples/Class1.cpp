#include<iostream>
using namespace std;

//struct CA
class CA
{
private:
	int a, b;
public:
	void input()
	{
		cout << "enter 2 nos." << endl;
		cin >> a >> b;
	}
	void print()
	{
		cout << "a =" << a << "b=" << b << endl;
	}
};

//---consumer code-----
int main()
{
	cout << "size of CA " << sizeof(CA) << endl;
	CA obj1;
	obj1.input();
	obj1.print();
	//obj1.a = 100;
	//obj1.b = 200;
	return 0;
}