#include<iostream>
using namespace std;
//an example on mutable qualifier and const objects.
class screen
{
private:
	int rows, columns;
	mutable int curR, curC;
public:
	screen(int p=1, int q=1, int r=1, int s=1):rows(p),columns(q),curR(r),curC(s)
	{   }
	void Resize() const
	{
		//read only area for data members
		curR=curR+1;
		curC=curC+1;
		cout <<"row ="<< rows <<", and column =" <<columns <<endl;
		cout <<"cursor row "<<curR <<"cursor column " <<curC << endl;
	}
	void Resize() 
	{
		//all data members can be modified here
		curR=curR+1;
		curC=curC+1;
		rows=rows+1;
		columns = columns +1;
		cout <<"row ="<< rows <<", and column =" <<columns <<endl;
		cout <<"cursor row "<<curR <<"cursor column " <<curC << endl;
	}
};
void main()
{
	//DOS USER
	const screen s1(25,80,1,1);
	s1.Resize();
	cout <<"----------------"<<endl;
	//windows user
	screen s2(14,30,1,1);
	s2.Resize();
}