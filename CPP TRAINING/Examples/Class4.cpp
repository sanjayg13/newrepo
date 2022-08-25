#include<iostream>
using namespace std;

class CA
{
private:
	int a, b;
public:
	CA();
	void input();
	void print();
};
//place the declarations outside the class body
CA::CA() 
{ 
	cout << __FUNCDNAME__ << endl;
	cout << "CA default constructor" << endl; 
	a = 0;
	b = 0;
}
void CA::input()
{
	cout << "enter 2 nos." << endl;
	cin >> this->a >> this->b;
}
void CA::print()
{
	cout << "a =" << this->a << "b=" << this->b << endl;
}

//---consumer code-----
int main()
{
	CA obj1;   //local objects reside on stack
	obj1.print();
	return 0;
}