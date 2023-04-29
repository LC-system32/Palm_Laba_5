
namespace Palm_Laba_5
{
    public class Time
    {
        public struct MyTime
        {
            private int hour;
            private int minute;
            private int second;

            public int Hour
            {
                get { return hour; }
                set
                {
                    if (value >= 24)
                    {
                        value %= 24;
                    }
                    hour = value;
                }
            }
            public int Minute
            {
                get { return minute; }
                set
                {
                    if (value >= 60)
                    {
                        Hour += value / 60;
                        value %= 60;
                    }
                    minute = value;
                }
            }
            public int Second
            {
                get { return second; }
                set
                {
                    if (value >= 60)
                    {
                        Minute += value / 60;
                        value %= 60;
                    }
                    second = value;
                }
            }
            public void Print()
            {
                Console.WriteLine("Коректний час");
                string[] tempTime = { hour.ToString("D2"), minute.ToString("D2"), second.ToString("D2")};
                string time = String.Join(":",tempTime);
                Console.WriteLine($"{time}");
            }
        };
    }
}
