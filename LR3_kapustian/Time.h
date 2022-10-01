#pragma once
#pragma once
#include <iostream>
#include <string>
#include <cmath>
using std::string;

class Time
{
private: int hours, minutes, seconds;
public:
	Time();
	Time(int hours, int minutes, int seconds);
	Time(string str);
	Time(int num_sec);
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

// Конструктор ініціалізує нулями, числами, рядком і секундами,
// Get-ери повертають значення полів,
// Read введення з клавіатури,
// Display виведення на екран,
// toString виведення рядок,
// CountDiffInSeconds рахує різницю між двома моментами часу в секундах,
// AddSeconds додає задану кількість секунд,
// CountSeconds вираховує кількість секунд з часу,
// CountMinutes вираховує кількість хвилин з часу,
// CompareTimes порівнює моменти часу (>, < або =)