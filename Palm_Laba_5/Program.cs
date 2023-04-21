using System;


class Program
{
    static private readonly char[] chars = { '.', ',', '<', '>', '/', '?', ';', ':', '\"', '\'', '\\', '[', ']', '{', '}', '=', '+', '_', '*' };
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
                for (int i = 0; i < value.Length; i++)
                {
                    for (int j = 0; j < chars.Length; j++)
                    {
                        if (value[i] == chars[j])
                        {
                            value = value.Remove(i,1);
                        }
                    }
                }
                surname = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Fatherhood
        {
            get { return fatherhood; }
            set { fatherhood = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string DirthDate
        {
            get { return dirthDate; }
            set { dirthDate = value; }
        }
        public string GradesToMath
        {
            get { return gradesToMath; }
            set { gradesToMath = value; }
        }
        public string GradesToPhysics
        {
            get { return gradesToPhysics; }
            set { gradesToPhysics = value; }
        }
        public string GradesToInformat
        {
            get { return gradesToInformat; }
            set { gradesToInformat = value; }
        }
        public int Scholarship
        {
            get { return scholarship; }
            set { scholarship = value; }
        }
    }
    static void Main()
    {
        Student stud = new Student();
    }
}