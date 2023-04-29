using static Palm_Laba_5.Time;

namespace Palm_Laba_5
{
    public class MainMyTime
    {
        static int TimeSinceMidnight(MyTime t)
        {
            int second = 0;
            second += t.Hour * Convert.ToInt32(Math.Pow(60,2));
            second += t.Minute * 60;
            second += t.Second;
            Console.WriteLine($"Ваш час в секундах від початку доби {second}");
            return second;
        }
        public static void EditTime(MyTime t) 
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
            EditTime(t);
        }
    }
}