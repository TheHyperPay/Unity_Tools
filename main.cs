using System;
using Time;

public class main {
	public static void Main() {
		Console.WriteLine(BasicTime.exchangeMillisecToTime(BasicTime.subtractTime(BasicTime.Time_MilliSec(), BasicTime.Time_MilliSec()+1000000)))
	}
}
