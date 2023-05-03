using System;


namespace Palm_Laba_5
{
    class MainLB
    {
        static void Main()
        {
            Console.WriteLine("Виберіть завдання \n 1)Час/Робота з часом \n 2)Ротота з структурами");
            int select;
            do
            {
                select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        MainMyTime mainMyTime = new MainMyTime();
                        mainMyTime.SetStartTime();
                        break;
                    case 2:
                        StudStruct studStruct = new StudStruct();
                        studStruct.FillStruct();
                        break;
                }

            } while (select != 0);
        }
    }
}
