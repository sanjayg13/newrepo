#include<iostream>
#include<typeinfo>
using namespace std;
//an example on raw names, by using the 'typeid' operator function
//from 'typeinfo' library

int main()
{
	cout << "raw name for char is:" << typeid(char).raw_name() << endl;
	cout << "raw name for int is:" << typeid(int).raw_name() << endl;
	cout << "raw name for float is:" << typeid(float).raw_name() << endl;
	cout << "raw name for double is:" << typeid(double).raw_name() << endl;
	cout << "raw name for bool is:" << typeid(bool).raw_name() << endl;
	cout << "raw name for void is:" << typeid(void).raw_name() << endl;
	return 0;
}