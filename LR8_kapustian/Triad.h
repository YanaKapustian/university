#pragma once
class Triad
{
private: int a; int b; int c;
public:
	Triad()
	{
		a = 0;
		b = 0;
		c = 0;
	}
	Triad(int an, int bn, int cn) 
	{
		a = an;
		b = bn;
		c = cn;
	}
	void Display();
	int FindMax();
	int FindMin();
};

//Конструктор ініціалізує нулями і числами
//FindMax і FindMin знаходять найбільше і шайменше число відповідно.

