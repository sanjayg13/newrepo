#include<iostream>
using namespace std;

class Avoidblow
{
protected: 
	int a,b;
public:
	Avoidblow(int x, int y):a(x),b(y) { }
	void fun2()   //doing business only with non-generic data
	{
		cout <<"Avoidblow::fun2 "<< endl;
		cout <<"a = " << a <<",b=" << b << endl;
	}
};

template<typename T> class blow:public Avoidblow
{
private:
	//int a, b;
	T c,d;
public:
	blow(int x, int y, T i, T j):Avoidblow(x,y) ,c(i), d(j) {     }
	void fun1()    // does business with both generic as well as non-generic data
	{
		cout <<"fun1<"<<typeid(T).name() <<">" << endl;
		cout <<"a = " << a <<",b=" << b << endl;
		cout <<"c = " << c <<",d = " << d << endl;
	}
	
};
//------------------------------
void main()
{
	blow<float> obj1(10,20, 45.12f, 56.32f);
	obj1.fun1();
	obj1.fun2();
	cout <<"---------------------"<<endl;
	blow<double> obj2(300,400, 98.34, 67.29);
	obj2.fun1();
	obj2.fun2();
}