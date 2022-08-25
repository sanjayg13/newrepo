#include<iostream>
using namespace std;

class rupees;  //forward declaration
class dollars
{
private:
	double d;
public:
	dollars(double = 0);
	operator rupees();
	void amount();
};

dollars::dollars(double x):d(x){  }
void dollars::amount() { cout << "amount in dollars:" << d << endl; }
//------------------------------------------------
class rupees
{
private:
	double r;
public:
	rupees(double = 0);
	operator dollars();
	void amount();
};

rupees::rupees(double x) :r(x) { }
void rupees::amount() { cout << "amount in rupees:" << r << endl; }
//*********************************
dollars::operator rupees()
{
	return rupees(d*70.0);   // (or)  return (d*70.0);
}
rupees::operator dollars()
{
	return dollars(r / 70.0);  // (or) return r/70.0;
}

//-----------consumer code----------------
int main()
{
	dollars d1(100), d2;
	rupees r1, r2(345343);
	cout << "------dollars to rupees----" << endl;
	r1 = d1;   // r1 = (rupees)d1;     // r1 = d1.operator rupees();
	d1.amount();
	r1.amount();
	cout << "------rupees to dollars ----" << endl;
	d2 = r2;  // d2 = (dollars) r2      //d2 = r2.operator dollars();
	d2.amount();
	r2.amount();
	return 0;
}

//*********************************