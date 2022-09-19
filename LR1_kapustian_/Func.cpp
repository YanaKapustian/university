#include"Func.h"
#include<iostream>
using namespace std;

Func Func::Init(double a, double b)
{
	Func tmp;
	tmp.a_coef = a;
	tmp.b_coef = b;
	return tmp;
}

void Func::Read()
{
	cout << "Input a coefficient" << endl;
	cin >> this->a_coef;
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
	this->x_var = -this->b_coef / this->a_coef;
	this->y_answ = this->a_coef * this->x_var + this->b_coef;
}
