#include "Timefuncslib.h"
#include <stdexcept>
#include <string>
#include <iostream>
using namespace std;
namespace Timefuncs
{
    Timefuncs::Timefuncs(int hours_t, int minutes_t, int seconds_t)
    {
        hours = hours_t;
        minutes = minutes_t;
        seconds = seconds_t;
    }
    Timefuncs::Timefuncs(string str)
    {
        char* ptr;
        char char_array[str.length()];
        strcpy(char_array, str.c_str());

        hours = stoi(strtok(char_array, ":"));
        minutes = stoi(strtok(NULL, ":"));
        seconds = stoi(strtok(NULL, ":"));
    }
    Timefuncs::Timefuncs(int num_sec)
    {
        hours = floor(num_sec / 3600);
        minutes = floor((num_sec - hours * 3600) / 60);
        seconds = (num_sec - hours * 3600) - minutes * 60;
    }
    Timefuncs::Timefuncs()
    {
        hours = 0;
        minutes = 0;
        seconds = 0;
    }

    void Timefuncs::Read(Timefuncs M)
    {
        cout << "Hours ";
        cin >> M.hours;
        cout << "Minutes ";
        cin >> M.minutes;
        cout << "Seconds ";
        cin >> M.seconds;
    }
    void Timefuncs::Display(Timefuncs M)
    {
        cout << "Hours = " << M.hours << endl;
        cout << "Minutes = " << M.minutes << endl;
        cout << "Seconds = " << M.seconds << endl;
    }

    string Timefuncs::toString(Timefuncs M)
    {
        string Timefuncs = to_string(M.hours) + ":" + to_string(M.minutes) + ":" + to_string(M.seconds);
        return Timefuncs;
    }
    int Timefuncs::CountDiffInSeconds(Timefuncs N, Timefuncs M)
    {
        int diffHours, diffMinutes, diffSeconds, diff;
        diffHours = abs(N.hours - M.hours);
        diffMinutes = abs(N.minutes - M.minutes);
        diffSeconds = abs(N.seconds - M.seconds);
        diff = diffHours * 3600 + diffMinutes * 60 + diffSeconds;
        return diff;
    }
    Timefuncs Timefuncs::AddSeconds(Timefuncs M, int num_sec)
    {
        int secAll, min, h;
        secAll = M.seconds + num_sec;
        if (secAll > 59)
        {
            min = floor(secAll / 60);
            M.minutes += min;
            M.seconds = secAll - min * 60;
        }
        if (M.minutes > 59)
        {
            h = floor(M.minutes / 60);
            M.hours += h;
            M.minutes -= h * 60;
        }
        if (M.hours > 23)
        {
            M.hours -= 24;
        }
        return M;
    }
    int Timefuncs::CountSeconds(Timefuncs M)
    {
        int secAll;
        secAll = M.seconds + M.minutes * 60 + M.hours * 3600;
        return secAll;
    }
    int Timefuncs::CountMinutes(Timefuncs M)
    {
        int secAll, min;
        secAll = M.seconds + M.minutes * 60 + M.hours * 3600;
        min = round(secAll / 60);
        return min;
    }
    string Timefuncs::CompareTimes(Timefuncs N, Timefuncs M)
    {
        int first, second;
        first = N.seconds + N.minutes * 60 + N.hours * 3600;
        second = M.seconds + M.minutes * 60 + M.hours * 3600;
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
    Timefuncs Timefuncs::operator+(Timefuncs tm)
    {
        Timefuncs tmp;
        tmp.hours = hours + tm.hours;
        tmp.minutes = minutes + tm.minutes;
        tmp.seconds = seconds + tm.seconds;
        if (tmp.seconds > 59)
        {
            tmp.minutes++;
            tmp.seconds -= 60;
        }
        if (tmp.minutes > 59)
        {
            tmp.hours++;
            tmp.minutes -= 60;
        }
        if (tmp.hours > 23)
        {
            tmp.hours -= 24;
        }
        return tmp;
    }
    Timefuncs Timefuncs::operator-(Timefuncs tm)
    {
        Timefuncs tmp;
        tmp.hours = hours - tm.hours;
        tmp.minutes = minutes - tm.minutes;
        tmp.seconds = seconds - tm.seconds;
        if (tmp.seconds < 0)
        {
            tmp.minutes--;
            tmp.seconds += 60;
        }
        if (tmp.minutes < 0)
        {
            tmp.hours--;
            tmp.minutes += 60;
        }
        if (tmp.hours < 0)
        {
            tmp.hours = 24 + tmp.hours;
        }
        return tmp;
    }
    Timefuncs Timefuncs::operator*(int n)
    {
        Timefuncs tmp;
        tmp.hours = hours * n;
        tmp.minutes = minutes * n;
        tmp.seconds = seconds * n;
        while (tmp.seconds > 59)
        {
            tmp.minutes++;
            tmp.seconds -= 60;
        }
        while (tmp.minutes > 59)
        {
            tmp.hours++;
            tmp.minutes -= 60;
        }
        while (tmp.hours > 23)
        {
            tmp.hours -= 24;
        }
        return tmp;
    }
}