#include"Func.h"
#include<iostream>
using namespace std;

Func Func::Init(double a, double x, double b, double y)
{
	Func tmp;
	tmp.a_coef = a;
	tmp.x_var = x;
	tmp.b_coef = b;
	tmp.y_answ = y;
	return tmp;
}

void Func::Read()
{
	cout << "Input a coefficient" << endl;
	cin >> this->a_coef;
	cout << "Input x variable" << endl;
	cin >> this->x_var;
	cout << "Input b coefficient" << endl;
	cin >> this->b_coef;
	
}

void Func::Display()
{
	cout << "A =" << a_coef << endl;
	cout << "X =" << x_var << endl;
	cout << "B =" << b_coef << endl;
	cout << "Y =" << y_answ;
}

void Func::Add()
{
	
	this->y_answ = this->a_coef * this->x_var + this->b_coef;
}
