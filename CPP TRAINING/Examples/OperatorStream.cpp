#include<iostream>
using namespace std;

//An example on stream operator overloading
class CA
{
	 //anywhere inside the class
	friend istream& operator >>(istream &input, CA &ob);
	friend ostream& operator <<(ostream& print, CA &ob);
private:
	int a, b;
};
//GLOBAL FUNCTIONS
istream& operator >>(istream &input, CA &ob)
{
	cout << "enter 2 nos." << endl;
	input >> ob.a >> ob.b;
	return input;
}

ostream& operator <<(ostream& print, CA &ob)
{
	print << "a =" << ob.a << ",b=" << ob.b << endl;
	return print;
}
//----consumer code -----
int main()
{
	CA obj1;
	//cin >> obj1;       // operator >>(cin, obj1);
	//cout << obj1;      // operator <<(cout, obj1);
	CA obj2;
	cin >> obj1 >> obj2;
	                // operator>>(operator >>(cin, obj1) ,obj2);
	cout << obj1 << obj2;
	                // operator <<(operator <<(cout, obj1) ,obj2);
}