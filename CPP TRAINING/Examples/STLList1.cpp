#include<iostream>
#include<list>
using namespace std;

int main()
{
	list<int> ls1;
	for (int i = 1; i <= 10; i++)
	{
		ls1.push_front(i);
	}
	cout << "size of the list after adding elements:" << ls1.size() << endl;
	//create an iterator object to traverse the list holding integers
	list<int>::iterator itr;
	//let the iterator point to the first node in the list
	itr = ls1.begin();
	//traverse the list
	while (itr != ls1.end())
	{
		cout << *itr << ",";   // cout << itr.operator *()
		itr++;                 // itr.operator ++(int);
	}
	//sort the contents of the list
	ls1.sort();
	//traverse the list
	itr = ls1.begin();
	cout << "contents of the list after sorting..." << endl;
	while (itr != ls1.end())
	{
		cout << *itr << ",";
		itr++;
	}
}