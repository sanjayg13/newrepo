#include<iostream>
using namespace std;
//an example function pointers and global functions

//PROGRAMMER 1
void Add(int x, int y) 
{ cout << "Add called, sum=" << x + y << endl; }
void Diff(int x, int y) 
{ cout << "Diff called, difference=" << x - y << endl; }

//PROGRAMMER 2
void compute(void(*ff)(int, int), int x, int y)
{
	cout << "compute business started..." << endl;
	(*ff)(x, y);
	cout << "compute business completed..." << endl;
}

//PROGRAMMER 3
int main()
{
	//approach 1
	void(*fp)(int, int) = &Add;
	compute(fp, 100, 200);
	cout << "------------" << endl;
	//approach 2
	compute(&Diff, 100, 50);
	return 0;
}
