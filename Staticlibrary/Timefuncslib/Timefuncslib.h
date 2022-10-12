#pragma once
#include <string>
using namespace std;
namespace Timefuncs
{
	class Timefuncs
	{
	private: int hours;
			int minutes;
			int seconds;
	public:
		Timefuncs();
		Timefuncs(int hours_t, int minutes_t, int seconds_t);
		Timefuncs(string str);
		Timefuncs(int num_sec);
		int GetHours(int hours) { return hours; };
		int GetMinutes(int minutes) { return minutes; };
		int GetSeconds(int seconds) { return seconds; };
		void Read(Timefuncs M);
		static void Display(Timefuncs M);
		static string toString(Timefuncs M);
		static int CountDiffInSeconds(Timefuncs N, Timefuncs M);
		static Timefuncs AddSeconds(Timefuncs M, int num_sec);
		static int CountSeconds(Timefuncs M);
		static int CountMinutes(Timefuncs M);
		static string CompareTimes(Timefuncs N, Timefuncs M);

		Timefuncs operator+(Timefuncs tm);
		Timefuncs operator-(Timefuncs tm);
		Timefuncs operator*(int n);
	};
}
