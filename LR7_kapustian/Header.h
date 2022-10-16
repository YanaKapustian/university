#pragma once
#include <iostream>
#include<math.h>
using namespace std;
class Division
{
private: int a; int b;
public:
	Division(int ac, int bc)
	{
		a = ac;
		b = bc;
	}
	int GetA() { return a; }
	int GetB() { return b; }
	//без специфікації виключень
	int divide1()
	{
		if (this->b != 0)
			return floor(this->a / this->b);
		else
			cout << "B can't be equal to 0" << endl;
	}
	//зі специфікацією throw()
	int divide2()
	{
		if (this->b == 0)
			throw "Division by zero";
		return floor(this->a / this->b);
	}
	//з конкретною специфікацією з відповідним стандартним виключенням
	int divide3()
	{
		if (this->b == 0)
			throw exception("Division by zero");
		return floor(this->a / this->b);
	}
	//специфікація із власним реалізованим виключенням
	int divide4()
	{
		if (this->b == 0)
			throw runtime_error("Division by zero");
		return floor(this->a / this->b);
	}
};
