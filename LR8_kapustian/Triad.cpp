#include "Triad.h"
#include <iostream>
using namespace std;

void Triad::Display()
{
	cout << "a = " << a << endl;
	cout << "b = " << b << endl;
	cout << "c = " << c << endl;
}

int Triad::FindMax()
{
    int max = a;
    if (b > max) {
        max = b;
    }
    if (c > max) {
        max = c;
    }
	return max;
}

int Triad::FindMin()
{
    int min = a;
    if (b > min) {
        min = b;
    }
    if (c > min) {
        min = c;
    }
    return min;
}
