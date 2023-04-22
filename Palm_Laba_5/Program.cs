using System;


class Program
{
    static private readonly char[] chars = { '.', ',', '\"', '\\', ' ' };
    public struct Student
    {
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public string dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;

        public string SurName
        {
            get { return surName; }
            set
            {
                Remove(value);
                surName = value;
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                Remove(value);
                firstName = value;
            }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                Remove(value);
                patronymic = value;
            }
        }
        public char Sex
        {
            get { return sex; }
            set
            {
                char[] correctState = { 'М', 'м', 'Ч', 'ч', 'Ж', 'ж', 'F', 'f' };

                bool checkCorrects = false;
                for (int i = 0; i < correctState.Length; i++)
                {
                    if (value == correctState[i])
                    {
                        checkCorrects = true;
                    }
                }
                if (checkCorrects == false)
                {
                    value = '-';
                    return;
                }
                else
                {
                    sex = value;
                    return;
                }
            }
        }
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                DateTime dateTime;
                bool tryParse = false;
                do
                {
                    tryParse = DateTime.TryParse(value, out dateTime);
                    if (tryParse == true)
                    { break; }
                    else
                    { Console.WriteLine("Введена невірна дата. Введіть її ще раз"); value = Console.ReadLine(); }
                } while (tryParse == false);
                dateOfBirth = dateTime.ToLongDateString();
            }
        }
        public char MathematicsMark
        {
            get { return mathematicsMark; }
            set
            {
                CheckedAndSetVal(value);

                mathematicsMark = value;
            }
        }
        public char PhysicsMark
        {
            get { return physicsMark; }
            set
            {
                CheckedAndSetVal(value);

                physicsMark = value;
            }
        }
        public char InformaticsMark
        {
            get { return informaticsMark; }
            set
            {
                CheckedAndSetVal(value);

                informaticsMark = value;
            }
        }
        public int Scholarship
        {
            get { return scholarship; }
            set
            {
                while (value != 0 && value <= 1234 && value >= 4321)
                {
                    Console.WriteLine("Були ведені невірні данні ,спробуйте ще раз");
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
        private char CheckedAndSetVal(char value)
        {
            if (Convert.ToInt32(value) < 2 && Convert.ToInt32(value) > 5)
            {
                value = '2';
            }
            return value;
        }
    }
    static void Print(Student[] stud)
    {
        bool check = false;
        for (int i = 0; i < stud.Length; i++)
        {
            if (Convert.ToInt32(stud[i].PhysicsMark) == 5)
            {
                double gpa = Convert.ToInt32(stud[i].MathematicsMark) + Convert.ToInt32(stud[i].InformaticsMark) + Convert.ToInt32(stud[i].PhysicsMark);
                Console.WriteLine($"Прізвище: {stud[i].SurName}\n" +
                                  $"Ім'я: {stud[i].FirstName}\n" +
                                  $"По батькові{stud[i].Patronymic}\n" +
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
            stud[i].SurName = Console.ReadLine();

            Console.WriteLine($"Введіть ім'я {i + 1} студенту");
            stud[i].FirstName = Console.ReadLine();

            Console.WriteLine($"Як його(її) звати по батькові {i + 1} студенту");
            stud[i].Patronymic = Console.ReadLine();

            Console.WriteLine("Вкажіть стать особи");
            stud[i].Sex = char.Parse(Console.ReadLine());

            Console.WriteLine($"Введіть рік народження {i + 1} студенту");
            stud[i].DateOfBirth = Console.ReadLine();

            Console.WriteLine($"Введіть оцінку з математики {i + 1} студенту");
            stud[i].MathematicsMark = char.Parse(Console.ReadLine());

            Console.WriteLine($"Введіть оцінку з фізики {i + 1} студенту");
            stud[i].PhysicsMark = char.Parse(Console.ReadLine());

            Console.WriteLine($"Введіть оцінку з інформатики {i + 1} студенту");
            stud[i].InformaticsMark = char.Parse(Console.ReadLine());

            Console.WriteLine($"Введіть розмір стипендії {i + 1} студенту");
            stud[i].Scholarship = int.Parse(Console.ReadLine());
        }
        Print(stud);
    }
}