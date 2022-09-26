// LR2_kapustian.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "Time.h"
using namespace std;
using std::string;

int main()
{
    Time oneTime;
    Time twoTime;
    oneTime = oneTime.Init("20:14:55");
    twoTime = twoTime.Init(0, 0, 0);
    twoTime.Read();
    oneTime.AddSeconds(7860);
    cout << oneTime.CountSeconds() << endl;
    cout << oneTime.CountMinutes() << endl;
    cout << oneTime.CompareTimes(twoTime) << endl;
    cout << oneTime.CountDiffInSeconds(twoTime) << endl;
    cout << twoTime.toString() << endl;
    oneTime.Display();
}

// Init ініціалізує числами, рядком і секундами,
// Read введення з клавіатури,
// Display виведення на екран,
// toString виведення рядок,
// CountDiffInSeconds рахує різницю між двома моментами часу в секундах,
// AddSeconds додає задану кількість секунд,
// CountSeconds вираховує кількість секунд з часу,
// CountMinutes вираховує кількість хвилин з часу,
// CompareTimes порівнює моменти часу (>, < або =)

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
