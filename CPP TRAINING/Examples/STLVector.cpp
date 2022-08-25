#include<iostream>
#include<vector>
using namespace std;

int main()
{
	vector<int> v1;
	//populate the vector
	for (int i = 1; i <= 10; i++)
	{
		v1.push_back(i);
	}
	cout << "size of the vector after pushing..." << v1.size() << endl;
	//traverse the vector
	vector<int>::iterator itr = v1.begin();
	while (itr != v1.end())
	{
		cout << *itr << ",";
		itr ++;
	}
	//insert some values onto the vector at 3rd index
	itr = v1.begin();
	itr += 2;
	/*
	   C++17 standards:
	   itr = itr + 2;
	*/
	v1.insert(itr, 100);
	v1.insert(itr, 200);
	cout << endl << "size of the vector after insertion:" << v1.size() << endl;
	cout << "contents of the vector after insertion:" << endl;
	itr = v1.begin();
	while (itr != v1.end())
	{
		cout << *itr << ",";
		itr++;
	}
	return 0;
}