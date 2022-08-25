#include<iostream>
using namespace std;

class CA
{
private:
	int a, b;
public:
	void input();
	void print();
};
//place the declarations outside the class body
void CA::input()
{
	cout << __FUNCDNAME__ << endl;
	cout << "enter 2 nos." << endl;
	cin >> this->a >> this->b;
}
void CA::print()
{
	cout << __FUNCDNAME__ << endl;
	cout << "a =" << this->a << "b=" << this->b << endl;
}

//---consumer code-----
int main()
{
	cout << "size of CA " << sizeof(CA) << endl;
	CA obj1;
	obj1.input();    
	obj1.print();    
	return 0;
}