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
        static void Difference(MyTime[] myTimes)
        {
            double[] resTimeOfMT = new double[myTimes.Length * 3];
            for (int i = 0; i < myTimes.Length; i++)
            {
                Console.WriteLine($"Введіть {i + 1} час");
                int[] time = Array.ConvertAll(Console.ReadLine().Trim().Split(':', '.', ','), int.Parse);
                myTimes[i].Hour = time[0];
                myTimes[i].Minute = time[1];
                myTimes[i].Second = time[2];
                resTimeOfMT[i * 3] = myTimes[i].Hour + Convert.ToDouble(myTimes[i].Minute) / 60 + Convert.ToDouble(myTimes[i].Second) / 120;
                resTimeOfMT[i * 3 + 1] = myTimes[i].Hour * 60 + myTimes[i].Minute + Convert.ToDouble(myTimes[i].Second) / 60;
                resTimeOfMT[i * 3 + 2] = myTimes[i].Hour * 60 * 60 + myTimes[i].Minute * 60 + myTimes[i].Second;
            }
            for (int i = 0; i < myTimes.Length; i += 2)
            {
                double resDiffInHour = resTimeOfMT[i * 3] - resTimeOfMT[i * 3 + 3];
                Console.WriteLine($"Різниця часу в годинах {resDiffInHour}");
                double resDiffInMin = resTimeOfMT[i * 3 + 1] - resTimeOfMT[i * 3 + 4];
                Console.WriteLine($"Різниця часу в хвилинах {resDiffInMin}");
                double resDiffInSec = resTimeOfMT[i * 3 + 2] - resTimeOfMT[i * 3 + 5];
                Console.WriteLine($"Різниця часу в секундах {resDiffInSec}\n");
            }
        }
        static void WhatLesson(MyTime mt)
        {
            double[] time = { mt.Hour, Convert.ToDouble(mt.Minute) / 100};
            if (time[0] + time[1] >= 8 && time[0] + time[1] <= 9.20)
            {
                Console.WriteLine("Зараз йде 1 пара");
            }
            if (time[0] + time[1] > 9.20 && time[0] + time[1] < 9.40)
            {
                Console.WriteLine("Перерва між 1 та 2 парою");
            }
            if (time[0] + time[1] >= 9.40 && time[0] + time[1] <= 11)
            {
                Console.WriteLine("Зараз йде 2 пара");
            }
            if (time[0] + time[1] > 11 && time[0] + time[1] < 11.20)
            {
                Console.WriteLine("Перерва між 2 та 3 парою");
            }
            if (time[0] + time[1] >= 11.20 && time[0] + time[1] <= 12.40)
            {
                Console.WriteLine("Зараз йде 3 пара");
            }
            if (time[0] + time[1] > 12.40 && time[0] + time[1] < 13)
            {
                Console.WriteLine("Перерва між 3 та 4 парою");
            }
            if (time[0] + time[1] >= 13 && time[0] + time[1] <= 14.20)
            {
                Console.WriteLine("Зараз йде 4 пара");
            }
            if (time[0] + time[1] > 14.20 && time[0] + time[1] < 14.40)
            {
                Console.WriteLine("Перерва між 4 та 5 парою");
            }
            if (time[0] + time[1] >= 14.40 && time[0] + time[1] <= 16)
            {
                Console.WriteLine("Зараз йде 5 пара");
            }
            if (time[0] + time[1]> 16 && time[0] + time[1] < 16.20)
            {
                Console.WriteLine("Перерва між 5 та 6 парою");
            }
            if (time[0] + time[1] >= 16.20 && time[0] + time[1] <= 17.40)
            {
                Console.WriteLine("Зараз йде 6 пара");
            }
            if (time[0] + time[1] > 17.40 && time[0] + time[1] < 17.50)
            {
                Console.WriteLine("Перерва між 6 та 7 парою");
            }
            if (time[0] + time[1] >= 17.50 && time[0] + time[1] <= 19.10)
            {
                Console.WriteLine("Зараз йде 7 пара");
            }
            if (time[0] + time[1] > 19.10 || time[0] + time[1] < 0)
            {
                Console.WriteLine("Пари вже скінчились");
            }

        }
        public static void WorkWithTime(MyTime t)
        {
            int select;
            do
            {
                Console.WriteLine("Введіть бажаний варіант\n" +
                    "1) Перетворюватиме вказаний час у кількість секунд, що пройшли від початку доби\n" +
                    "2) Перетворюватиме кількість секунд, що пройшли від початку доби\n" +
                    "3) Додаватиме до структури одну секунду\n" +
                    "4) Додаватиме до структури одну хвилину\n" +
                    "5) Додаватиме до структури одну годину\n" +
                    "6) Додаватиме до структури вказану кількість секунд s (яка може бути довільною, в тому числі більшою 60, і навіть більшою 24×60×60 = 86400, а також від’ємною)\n" +
                    "7) Різниця між двома моментами часу\n");
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
                    case 7:
                        Console.WriteLine("Введіть кількість моментів часу");
                        MyTime[] myTimes = new MyTime[int.Parse(Console.ReadLine())];
                        if (myTimes.Length % 2 != 0)
                        {
                            Console.WriteLine("Кількість введеного часу була не парна тому буде кількість збільшена на 1");
                            myTimes = new MyTime[myTimes.Length + 1];
                        }
                        Difference(myTimes);
                        break;
                    case 8:
                        WhatLesson(t);
                        break;
                    default:
                        break;
                }
            } while (select != 0);

        }
        public void SetStartTime()
        {
            Console.WriteLine("Введіть ваш час");
            int[] time = Array.ConvertAll(Console.ReadLine().Trim().Split(':', '.', ','), int.Parse);
            MyTime t = new MyTime();
            t.Hour = time[0];
            t.Minute = time[1];
            t.Second = time[2];
            t.Print();
            WorkWithTime(t);
        }
    }
}