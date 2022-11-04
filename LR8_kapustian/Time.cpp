#include "Time.h"
#include <iostream>
#include <ctime>
#include <string>
#include <cstring>  
#include <sstream>
#include <cmath>

using namespace std;
using std::string;

void Time::Read()
{
    cout << "Hours ";
    cin >> this->hours;
    cout << "Minutes ";
    cin >> this->minutes;
    cout << "Seconds ";
    cin >> this->seconds;
}

void Time::Display()
{
    cout << "Hours = " << hours << endl;
    cout << "Minutes = " << minutes << endl;
    cout << "Seconds = " << seconds << endl;
}

string Time::toString()
{
    string time = to_string(this->hours) + ":" + to_string(this->minutes) + ":" + to_string(this->seconds);
    return time;
}
int Time::CountDiffInSeconds(Time M)
{
    int diffHours, diffMinutes, diffSeconds, diff;
    diffHours = abs(this->hours - M.hours);
    diffMinutes = abs(this->minutes - M.minutes);
    diffSeconds = abs(this->seconds - M.seconds);
    diff = diffHours * 3600 + diffMinutes * 60 + diffSeconds;
    return diff;
}
void Time::AddSeconds(int num_sec)
{
    int secAll, min, h;
    secAll = this->seconds + num_sec;
    if (secAll > 59)
    {
        min = floor(secAll / 60);
        this->minutes += min;
        this->seconds = secAll - min * 60;
    }
    if (this->minutes > 59)
    {
        h = floor(this->minutes / 60);
        this->hours += h;
        this->minutes -= h * 60;
    }
    if (this->hours > 23)
    {
        this->hours -= 24;
    }
}
int Time::CountSeconds()
{
    int secAll;
    secAll = this->seconds + this->minutes * 60 + this->hours * 3600;
    return secAll;
}
int Time::CountMinutes()
{
    int secAll, min;
    secAll = this->CountSeconds();
    min = round(secAll / 60);
    return min;
}
string Time::CompareTimes(Time M)
{
    int first, second;
    first = this->CountSeconds();
    second = M.CountSeconds();
    if (first > second)
    {
        return to_string(first) + " > " + to_string(second);
    }
    else if (first < second)
    {
        return to_string(first) + " < " + to_string(second);
    }
    else
    {
        return to_string(first) + " = " + to_string(second);
    }
}
