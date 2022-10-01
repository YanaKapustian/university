#include <iostream>
#include "Time.h"
using namespace std;
using std::string;

int main()
{
    Time oneTime("10:14:55");
    Time twoTime("07:12:30");
    Time threeTime;

    threeTime = oneTime + twoTime;
    cout << threeTime.toString() << endl;

    threeTime = oneTime - twoTime;
    cout << threeTime.toString() << endl;

    threeTime = oneTime * 3;
    cout << threeTime.toString() << endl;
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
// Оператор + додає відповідно години, хвилини і секунди
// Оператор - віднімає відповідно години, хвилини і секунди
// Оператор * множить години, хвилини і секунди на задане число
