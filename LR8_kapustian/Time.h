#pragma once
#include "Triad.h"
#include <iostream>
using namespace std;
class Time :
    public Triad
{
private: int seconds; int minutes; int hours;
public:
    Time()
    {
        seconds = 0;
        minutes = 0;
        hours = 0;
    }
    Time(int a, int b, int c):Triad(a, b, c)
    {
        seconds = c;
        minutes = b;
        hours = a;
    }
    int GetHours() { return hours; };
    int GetMinutes() { return minutes; };
    int GetSeconds() { return seconds; };
    void Read();
    void Display();
    string toString();
    int CountDiffInSeconds(Time M);
    void AddSeconds(int num_sec);
    int CountSeconds();
    int CountMinutes();
    string CompareTimes(Time M);
};

//Конструктор ініціалізує нулями і числами,
// Get-ери повертають значення полів,
// Read введення з клавіатури,
// Display виведення на екран,
// toString виведення рядок,
// CountDiffInSeconds рахує різницю між двома моментами часу в секундах,
// AddSeconds додає задану кількість секунд,
// CountSeconds вираховує кількість секунд з часу,
// CountMinutes вираховує кількість хвилин з часу,
// CompareTimes порівнює моменти часу (>, < або =)
