#include <iostream>
#include<math.h>
#include"Header.h"
using namespace std;


int main()
{
	Division one(10, 0);
	int res1 = one.divide1();
	cout << "Output 1 is " << res1 << endl;
	try
	{
		int res2 = one.divide2();
		cout << "Output 2 is " << res2 << endl;
	}
	catch (const char* err)
	{
		cout << "Error! Something went wrong..." << endl;
	}
	try
	{
		int res3 = one.divide3();
		cout << "Output 3 is " << res3 << endl;
	}
	catch (const exception& err)
	{
		cout << "Error! " << err.what() << endl;
	}
	try
	{
		int res4 = one.divide4();
		cout << "Output 4 is " << res4 << endl;
	}
	catch (const runtime_error err)
	{
		cout << "Runtime error " << err.what() << endl;
	}
	catch (const overflow_error err)
	{
		cout << "Overflow error " << err.what() << endl;
	}
}