#include<iostream>
using namespace std;

//non-generic classes
class flute
{
public:
	void play() { cout << "playing flute..." << endl; }
};
class drums
{
public:
	void play() { cout << "playing drums..." << endl; }
};
class piano
{
public:
	void play() { cout << "playing piano..." << endl; }
};
//GENERIC CLASS
template<typename T1, typename T2, typename T3> class compose
{
private:
	T1 obj1;  T2 obj2;  T3 obj3;
public:
	void compose_music();
};

template<typename T1, typename T2, typename T3>
void compose<T1, T2, T3>::compose_music()
{
	obj1.play();
	obj2.play();
	obj3.play();
}
//---consumer code----
int main()
{
	compose<flute, drums, piano> music1;
	music1.compose_music();
	cout << "----------------" << endl;
	compose<drums, drums, piano> music2;
	music2.compose_music();
	return 0;
}






