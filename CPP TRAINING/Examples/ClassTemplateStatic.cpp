#include<iostream>
using namespace std;
//An example on static data as a member of a GENERIC class.

template<typename T> class CA
{
private:
	T a;
	static int b;
public:
	CA(T);
	static void count();
};
//define memory for the static data member
template<typename T> int CA<T>::b;

template<typename T> CA<T>::CA(T x) :a(x)
{
	b = b + 1;
}

template<typename T> void CA<T>::count()
{
	cout << "Objects of type: CA<" << typeid(T).name() << "> =" << b << endl;
}
//--- consumer code----
int main()
{
	CA<int> obj1(100);
	CA<float> obj2(45.12f), obj3(67.21f);
	CA<double> obj4(78.94);

	CA<int>::count();
	CA<float>::count();
	CA<double>::count();

	return 0;
}

