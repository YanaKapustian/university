#pragma once
#include <iostream>
#include <string>
using std::string;

class Time
{
private: int hours, minutes, seconds;
public:
	Time Init(int hours, int minutes, int seconds);
	Time Init(string str);
	Time Init(int num_sec);
	void Read();
	void Display();
	string toString();
	int CountDiffInSeconds(Time M);
	void AddSeconds(int num_sec);
	int CountSeconds();
	int CountMinutes();
	string CompareTimes(Time M);
};

// Init ініціалізує числами, рядком і секундами,
// Read введення з клавіатури,
// Display виведення на екран,
// toString виведення рядок,
// CountDiffInSeconds рахує різницю між двома моментами часу в секундах,
// AddSeconds додає задану кількість секунд,
// CountSeconds вираховує кількість секунд з часу,
// CountMinutes вираховує кількість хвилин з часу,
// CompareTimes порівнює моменти часу (>, < або =)