#include<iostream>
using namespace std;

class CA
{
private:
	int* p;
public:
	CA(int* x) :p(x) { }
	
	operator bool()
	{
		if (p != NULL)
			return true;
		else
			return false;
	}
};

int main()
{
	//int *q = (int*)malloc(sizeof(int));
	int *q = NULL;
	CA obj1(q);
	if (obj1)    // if(obj1.operator bool())
		cout << "Pointing to a valid resource.." << endl;
	else
		cout << "Pointing to NULL" << endl;
	return 0;
}


