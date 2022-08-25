#include<iostream>
using namespace std;
//An example on default arguments, 

void Add(int=1, int=1);

//Cannot overload with these signatures
//void Add();
//void Add(int);
int main()
{
	Add();                 // Add(1,1);
	Add(100);              //Add(100, 1);
	Add(10, 20);
	return 0;
}

void Add(int x, int y)
{
	cout << "sum is " << x + y << endl;
}