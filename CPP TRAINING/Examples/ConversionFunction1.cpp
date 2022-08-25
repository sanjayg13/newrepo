#include<iostream>
using namespace std;
//an example on conversion function
/*
	- Conversion functions take data-type as their names
	- All conversion functions must and should return a value of 
	  the type function-name.
	- As such we are not supposed to explicitly state the return-type
	- Conversion functions do not take any known formal parameters
*/
class CA
{
private:
	int a, b;
public:
	CA(int x = 0, int y = 0) :a(x), b(y) {}
	operator int();
};
CA::operator int()
{
	cout << "operator int called" << endl;
	return a + b;
}
//--- consumer code-----------
int main()
{
	CA obj1(10, 20);
	int x;
	//approach-1
	x = (int)obj1;   // (or) x = obj1;  --> x = obj1.operator int();
	cout << "x =" << x << endl;
	//approach-2
	cout << (int)obj1 << endl;  // cout << obj1.operator int() << endl;
	return 0;
}





