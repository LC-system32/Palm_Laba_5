using static Palm_Laba_5.Time;

namespace Palm_Laba_5
{
    public class MainMyTime
    {
        static int TimeSinceMidnight(MyTime t)
        {
            int second = 0;
            second += t.Hour * Convert.ToInt32(Math.Pow(60, 2));
            second += t.Minute * 60;
            second += t.Second;
            Console.WriteLine($"Ваш час в секундах від початку доби {second}");
            return second;
        }
        static MyTime TimeSinceMidnight()
        {
            int t = int.Parse(Console.ReadLine());
            MyTime stud = new MyTime();
            stud.Second = t;
            stud.Print();
            return stud;
        }
        static MyTime AddOneSecond(MyTime t)
        {
            t.Second += 1;
            t.Print();
            return t;
        }
        static MyTime AddOneMinute(MyTime t)
        {
            t.Minute += 1;
            t.Print();
            return t;
        }
        static MyTime AddOneHour(MyTime t)
        {
            t.Hour += 1;
            t.Print();
            return t;
        }
        static MyTime AddSeconds(MyTime t)
        {
            int s = int.Parse(Console.ReadLine());
            t.Second += s;
            t.Print();
            return t;
        }
        public static void ReadTime(MyTime t)
        {
            int select;
            do
            {
                Console.WriteLine("Введіть бажаний варіант");
                select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        TimeSinceMidnight(t);
                        break;
                    case 2:
                        TimeSinceMidnight();
                        break;
                    case 3:
                        t = AddOneSecond(t);
                        break;
                    case 4:
                        t = AddOneMinute(t);
                        break;
                    case 5:
                        t = AddOneHour(t);
                        break;
                    case 6:
                        t = AddSeconds(t);
                        break;
                    default:
                        break;
                }
            } while (select != 0);

        }
        public void MainB()
        {
            Console.WriteLine("Введіть ваш час");
            int[] time = Array.ConvertAll(Console.ReadLine().Trim().Split(':', '.', ','), int.Parse);
            MyTime t = new MyTime();
            t.Hour = time[0];
            t.Minute = time[1];
            t.Second = time[2];
            t.Print();
            ReadTime(t);
        }
    }
}