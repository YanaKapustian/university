#pragma once
struct Func
{
	double a_coef, x_var, b_coef, y_answ;
	Func Init(double a, double b);
	void Read();
	void Display();
	void Add();
};
