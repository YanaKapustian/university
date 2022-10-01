#include <iostream>
#include "Time.h"
using namespace std;
using std::string;

int main()
{
    Time oneTime("20:14:55");
    Time twoTime(0, 0, 0);
    twoTime.Read();
    oneTime.AddSeconds(7860);
    cout << oneTime.CountSeconds() << endl;
    cout << oneTime.CountMinutes() << endl;
    cout << oneTime.CompareTimes(twoTime) << endl;
    cout << oneTime.CountDiffInSeconds(twoTime) << endl;
    cout << twoTime.toString() << endl;
    oneTime.Display();
}

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
