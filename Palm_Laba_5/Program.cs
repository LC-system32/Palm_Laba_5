using System;


class Program
{
    static private readonly char[] chars = { '.', ',', '\"', '\\', ' ' };
    public struct Student
    {
        private string surname;
        private string name;
        private string fatherhood;
        private string state;
        private string dirthDate;
        private string gradesToMath;
        private string gradesToPhysics;
        private string gradesToInformat;
        private int scholarship;

        public string Surname
        {
            get { return surname; }
            set
            {
                Remove(value);
                surname = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                Remove(value);
                name = value;
            }
        }
        public string Fatherhood
        {
            get { return fatherhood; }
            set
            {
                Remove(value);
                fatherhood = value;
            }
        }
        public string State
        {
            get { return state; }
            set
            {
                Remove(value);
                char[] correctState = { 'М', 'м', 'Ч', 'ч', 'Ж', 'ж', 'F', 'f' };

                bool checkCorrects = true;
                if (value.Length != 0)
                {
                    for (int i = 0; i < correctState.Length; i++)
                    {
                        if (value[0] != correctState[i])
                        {
                            checkCorrects = false;
                        }
                    }
                }
                if (checkCorrects == true && value.Length != 0)
                {
                    state = value;
                }
                else
                {
                    value = "-";
                }
            }
        }
        public string BirthDate
        {
            get { return dirthDate; }
            set
            {
                DateTime dateTime;
                bool tryParse = false;
                do
                {
                    tryParse = DateTime.TryParse(value, out dateTime);
                    if (tryParse == true)
                    {  break; }
                    else
                    { Console.WriteLine("Введена невірна дата. Введіть її ще раз"); value = Console.ReadLine(); }
                } while (tryParse == false);
                dirthDate = dateTime.ToLongDateString();
            }
        }
        public string GradesToMath
        {
            get { return gradesToMath; }
            set
            {
                CheckedAndSetVal(value);
                gradesToMath = value;
            }
        }
        public string GradesToPhysics
        {
            get { return gradesToPhysics; }
            set
            {
                CheckedAndSetVal(value);

                gradesToPhysics = value;
            }
        }
        public string GradesToInformat
        {
            get { return gradesToInformat; }
            set
            {
                CheckedAndSetVal(value);

                gradesToInformat = value;
            }
        }
        public int Scholarship
        {
            get { return scholarship; }
            set
            {
                while (value != 0 && value <= 1234 && value >= 4321)
                {
                    value = int.Parse(Console.ReadLine());
                }
                scholarship = value;
            }
        }
        private string Remove(string value)
        {
            if (value.Length != 0)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    for (int j = 0; j < chars.Length; j++)
                    {
                        if (value[i] == chars[j])
                        {
                            value = value.Remove(i, 1);
                            i--;
                            break;
                        }
                    }
                }
            }
            else
            {
                value = "-";
            }
            return value;
        }
        private string CheckedAndSetVal(string value)
        {
            if (value != "-")
            {
                while (Convert.ToInt32(value) < 2 && Convert.ToInt32(value) > 5)
                {
                    value = Console.ReadLine();
                }
            }
            return value;
        }
    }
    static void Print(Student[] stud)
    {
        bool check = false;
        for (int i = 0; i < stud.Length; i++)
        {
            if (Convert.ToInt32(stud[i].GradesToPhysics) == 5)
            {
                double gpa = Convert.ToInt32(stud[i].GradesToMath) + Convert.ToInt32(stud[i].GradesToInformat) + Convert.ToInt32(stud[i].GradesToPhysics);
                Console.WriteLine($"Прізвище: {stud[i].Surname}\n" +
                                  $"Ім'я: {stud[i].Name}\n" +
                                  $"По батькові{stud[i].Fatherhood}\n" +
                                  $"Середній бал: {gpa / 3}\n" +
                                  $"Стипендія: {stud[i].Scholarship}\n");
                check = true;
            }
        }
        if (check == false)
        {
            Console.WriteLine("Таких студентів немає(");
        }
    }
    static void Main()
    {
        Console.WriteLine("Введіть кількість студентів");
        int n = int.Parse(Console.ReadLine());
        Student[] stud = new Student[n];
        for (int i = 0; i < stud.Length; i++)
        {
            Console.WriteLine($"Введіть прізвище {i + 1} студенту");
            stud[i].Surname = Console.ReadLine();

            Console.WriteLine($"Введіть ім'я {i + 1} студенту");
            stud[i].Name = Console.ReadLine();

            Console.WriteLine($"Як його(її) звати по батькові {i + 1} студенту");
            stud[i].Fatherhood = Console.ReadLine();

            Console.WriteLine("Вкажіть стать особи");
            stud[i].State = Console.ReadLine();

            Console.WriteLine($"Введіть рік народження {i + 1} студенту");
            stud[i].BirthDate = Console.ReadLine();

            Console.WriteLine($"Введіть оцінку з математики {i + 1} студенту");
            stud[i].GradesToMath = Console.ReadLine();

            Console.WriteLine($"Введіть оцінку з фізики {i + 1} студенту");
            stud[i].GradesToPhysics = Console.ReadLine();

            Console.WriteLine($"Введіть оцінку з інформатики {i + 1} студенту");
            stud[i].GradesToInformat = Console.ReadLine();

            Console.WriteLine($"Введіть розмір стипендії {i + 1} студенту");
            stud[i].Scholarship = int.Parse(Console.ReadLine());
        }
        Print(stud);
    }
}