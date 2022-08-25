#include<iostream>
using namespace std;

template<typename T = double> class CA   // 'double' is default type
{
private:
	T a, b;
public:
	CA(T);
	CA(T, T);
	~CA();
	void sum();
};

template<typename T> CA<T>::CA(T x) :a(x), b(x)
{
	cout << "CA<" << typeid(T).name() << "> one arg. constructor" << endl;
}
template<typename T> CA<T>::CA(T x, T y) : a(x), b(y)
{
	cout << "CA<" << typeid(T).name() << "> two arg. constructor" << endl;
}
template<typename T> CA<T>::~CA()
{
	cout << "~CA<" << typeid(T).name() << "> destructor" << endl;
}
template<typename T> void CA<T>::sum()
{
	cout << "CA::sum<" << typeid(T).name() << "> =" << a + b << endl;
}
/*
SPECIALIZE THE COMPLETE GENERIC CLASS CA such a way that its instances
 for type CHAR is not allowed
*/
template<> class CA<char>
{
private:
	CA();
	CA(char);
	CA(char, char);
};

//---consumer code-----
int main()
{
	CA<int> obj1(10, 20);
	obj1.sum();
	CA<float> obj2(45.12f, 78.32f);
	obj2.sum();
	CA<> obj3(98.21, 87.45);  // CA<double> obj3(98.21, 87.45);
	obj3.sum();
	cout << "-----------------" << endl;
	CA<char> obj4('r', 'w');
	obj4.sum();
	return 0;
}