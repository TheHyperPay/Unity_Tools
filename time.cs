using System;
using System.Threading;

namespace Time
{
	public static class BasicTime
	{
		public static string Time_Now_UTC()
		{
			return DateTime.UtcNow.ToString("yyyy-MM-dd ddd HH:mm:ss.ffff");
		}
		public static string Time_Now_Local()
		{
			return DateTime.Now.ToString("yyyy-MM-dd ddd HH:mm:ss.ffff");
		}
		
		private static DateTimeOffset convertTime_Now()
		{
			DateTimeOffset dto = new DateTimeOffset(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond, TimeSpan.Zero);
			Console.WriteLine(dto);
			return dto;
		}
		public static Int64 Time_MilliSec()
		{
			return convertTime_Now().ToUnixTimeMilliseconds();
		}
		
		private static Int64 subtractTime(Int64 first, Int64 end)
		{
			return end-first;
		}
		
		private static string exchangeMillisecToTime(Int64 millisec)
		{
			Int64 mill=millisec%1000;
			Int64 sec=(millisec/1000)%60;
			Int64 min=(millisec/1000/60)%60;
			Int64 hour=(millisec/1000/60/60)%24;
			
			return ToString(hour)+":"+ToString(min)+":"+ToString(sec)+"."+ToString(mill);
		}
	}
	
	public static class Timer
	{
		
	}
	
	public static class Stopwatch
	{
		const int MAX_STOPWATCH_PLAY=99;
		static Int64[,] stopwatchLog=new Int64[MAX_STOPWATCH_PLAY,3]; //Number Of Stopwatches
		const int START_TIME=0;
		const int END_TIME=1;
		const int PAUSE_TIME=2;
		
		public static void Start(int code)
		{
			if(code>=MAX_STOPWATCH_PLAY || code<0)
			{
				Console.WriteLine("code Value Has Problem");
				return;
			}
			
			stopwatchLog[code, START_TIME]=BasicTime.Time_MilliSec();
		}
		
		public static void Stop(int code)
		{
			if(code>=MAX_STOPWATCH_PLAY || code<0)
			{
				Console.WriteLine("code Value Has Problem");
				return;
			}
			
			stopwatchLog[code, END_TIME]=BasicTime.Time_MilliSec();
		}
		
		public static void Pause(int code, bool OnOff)
		{
			
		}
		
		public static string printTime(int code)
		{
			return "";
		}
		
		public static string checkStopwatch(int code)
		{
			if(code>=MAX_STOPWATCH_PLAY || code<0)
			{
				Console.WriteLine("code Value Has Problem");
				return "";
			}
			return "l";
		}
	}
	
	
}
