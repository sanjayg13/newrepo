#include<iostream>
using namespace std;
//an example function pointers and global functions

//PROGRAMMER 1
void Add(int x, int y)
{
	cout << "Add called, sum=" << x + y << endl;
}
void Diff(int x, int y)
{
	cout << "Diff called, difference=" << x - y << endl;
}

typedef void(*FP)(int, int);

//PROGRAMMER 2
void compute(FP ff, int x, int y)    // void(*ff)(int, int)
{
	cout << "compute business started..." << endl;
	(*ff)(x, y);
	cout << "compute business completed..." << endl;
}

//PROGRAMMER 3
int main()
{
	//approach 1
	FP fp = &Add;          //void(*fp)(int, int) = &Add;
	compute(fp, 100, 200);
	cout << "------------" << endl;
	//approach 2
	compute(&Diff, 100, 50);
	return 0;
}
