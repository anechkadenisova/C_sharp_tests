using System;
namespace home_5
{
    public class Student
    {
        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int MathMark { get; set; }
        public int PhysicalEducationMark { get; set; }
        public int BiologyMark { get; set; }
        public int Reward { get; set; }

        //public static string[] someNames = new string[] {"Kostya", "Vera", "Sveta", "Ivan", "Anna", "Nastya", "Karina", "Artem", "Kirill", "Mark", "Sergey", "Polina", "Timofey" };

        public Student(int id, string name, int age, string group, int mathMark, int physicalEducationMark, int biologyMark, int reward)

        {
            Id = id;
            Name = name;
            Age = age;
            Group = group;
            MathMark = mathMark;
            PhysicalEducationMark = physicalEducationMark;
            BiologyMark = biologyMark;
            Reward = reward;

        }

        public static Student[] GenerateStudents()
        {
            var students = new Student[15];
            var rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                //int reward = 100;
                students[i] = new Student(i, "Group1 Student " + i, 18 + rnd.Next(3), "Group1", rnd.Next(1, 11), rnd.Next(1, 11), rnd.Next(1, 11), rnd.Next(1, 100));
                students[i + 5] = new Student(i + 5, "Group2 Student " + i, 18 + rnd.Next(3), "Group2", rnd.Next(1, 11), rnd.Next(1, 11), rnd.Next(1, 11), rnd.Next(1, 100));
                students[i + 10] = new Student(i + 10, "Group3 Student " + i, 18 + rnd.Next(3), "Group3", rnd.Next(1, 11), rnd.Next(1, 11), rnd.Next(1, 11), rnd.Next(1, 100));
            }

            return students;
        }

        public static void PrintBestMathStudents(Student[] students)
        {
            Console.WriteLine("Students with the best Math mark:");
            var bestMathMark = students.Max(student => student.MathMark);

            foreach (var student in students)
            {
                if (student.MathMark == bestMathMark)
                {
                    Console.WriteLine($"{student.Name}, Math mark: {student.MathMark}");
                }
            }

            Console.WriteLine();
        }

        public static void PrintBestPhysicalEducationStudents(Student[] students)
        {
            Console.WriteLine("Students with the best Physical Education mark:");
            var bestPhysicalEducationMark = students.Max(student => student.PhysicalEducationMark);

            foreach (var student in students)
            {
                if (student.PhysicalEducationMark == bestPhysicalEducationMark)
                {
                    Console.WriteLine($"{student.Name}, Physical Education mark: {student.PhysicalEducationMark}");
                }
            }

            Console.WriteLine();
        }

        public static void PrintBestBiologyStudents(Student[] students)
        {
            Console.WriteLine("Students with the best Biology mark:");
            var bestBiologyMark = students.Max(student => student.BiologyMark);

            foreach (var student in students)
            {
                if (student.BiologyMark == bestBiologyMark)
                {
                    Console.WriteLine($"{student.Name}, Biology mark: {student.BiologyMark}");
                }
            }

            Console.WriteLine();
        }
        /*
        public static void SetRewards(Student[] students)
        {
            foreach (var group in new string[] { "Group1", "Group2", "Group3" })
                {
                    var bestAverageMark = students.Where(student =>
        */

        public void SetReward(int reward)
        {
            if (reward < 0)
            {
                Reward = 0;
            }
            else if (reward > 100)
            {
                Reward = 100;
            }
            else
            {
                Reward = reward;

            }
        }
        
    }
}