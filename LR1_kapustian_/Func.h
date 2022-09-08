#pragma once
struct Func
{
	double a_coef, x_var, b_coef, y_answ;
	Func Init(double a, double x, double b, double y);
	void Read();
	void Display();
	void Add();

};
