#include<iostream>
using namespace std;
//an example on binary operator overloading.
class CA
{
private:
	int a, b;
public:
	CA(int = 0, int = 0);
	void print() const;
	CA operator +(CA &x);  // CA operator +(CA* const this, CA &x);
};

CA::CA(int x, int y) :a(x), b(y) { }

void CA::print() const { cout << "a=" << a << ",b=" << b << endl; }

CA CA::operator +(CA &x)
{
	cout << "operator + called" << endl;
	CA temp;
	temp.a = this->a + x.a;
	temp.b = this->b + x.b;
	return temp;
}
//**********consumer code************
int main()
{
	CA obj1(10, 20), obj2(30, 40);
	CA result;
	//result = obj1.Add(obj2);
	//result = obj1 + obj2;        //result = obj1.operator +(obj2);
	CA obj3(50, 60);
	result = obj1 + obj2 + obj3;
	             // result = (obj1.operator +(obj2)).operator +(obj3);
	result.print();
	return 0;
}