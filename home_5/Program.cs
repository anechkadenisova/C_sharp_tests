using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using home_5;


/// <summary>
/// . Coздайте класс Student, в классе используйте поля Id, Name, Age, Group, MathMark
/// (Оценка по математике от 1 до 10 включительно), PhysicalEducationMark
/// (Оценка по физкультуре от 1 до 10), BiologyMark (Оценка по биологии от 1 до 10),
/// Reward (денежное вознаграждение за хорошую учебу)
///Допустим есть 3 группы (Group1, Group2, Group3).
///Создайте 3 массива студентов по 5 в каждой группе.
///Оценки по дисциплинам задайте с использованием Random
///Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой по Математике.
///Если существуют студенты с одинаковыми наилучшими оценками - выведите любого из них.
///(ex: Anton, Math mark: 10)
///Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой
///по Физкультуре. Если существуют студенты с одинаковыми наилучшими оценками -
///выведите любого из них.
///Создайте метод вывода в консоль студента из каждой группы с наилучшей оценкой
///по Биологии. Если существуют студенты с одинаковыми наилучшими оценками -
///выведите любого из них.
///Установите каждому из лучших студентов выше - денежное вознаграждение в рублях - reward
///(rand: 0 - 100) (предусмотрите, чтобы нельзя было установить значение reward < 1 рубля)
///Создайте методы подсчета и вывода среднего балла группы студентов по каждой из дисциплин
///и вывода этой информации в консоль (разные методы) (ex: Group1, avarage mark math: 8.3)
///Создайте метод расчета среднего балла группы студентов по всем 3 дисциплинам
///(средняя оценка группы по каждой дисциплине / количество дисциплин) и выведите
///эту информацию в консоль. 
///(Avearage mark of Group1 - Math, PhysicalEducation, Biology - 8.3)
///Добавьте каждому студенту из группы с наибольшим средним баллом по всем
///дисциплинам произвольный reward.
///Выведите на экран студента с наибольшим reward. Если таких студентов
///несколько - выведите их всех
/// </summary>
class Program
{
    static void Main(string[] args)
    {

        Random random = new Random();

        // Create 3 arrays of students with 5 students in each group
        Student[] group1 = new Student[5];
        for (int i = 0; i < group1.Length; i++)
        {
            int id = i + 1;
            string name = "Student " + id;
            int age = random.Next(18, 25);
            string group = "Group1";
            int mathMark = random.Next(1, 11);
            int physicalEducationMark = random.Next(1, 11);
            int biologyMark = random.Next(1, 11);
            int reward = mathMark * 10 + physicalEducationMark * 5 + biologyMark * 7;
            group1[i] = new Student(id, name, age, group, mathMark, physicalEducationMark, biologyMark, reward);
        }

        Student[] group2 = new Student[5];
        for (int i = 0; i < group2.Length; i++)
        {
            int id = i + 6;
            string name = "Student " + id;
            int age = random.Next(18, 25);
            string group = "Group2";
            int mathMark = random.Next(1, 11);
            int physicalEducationMark = random.Next(1, 11);
            int biologyMark = random.Next(1, 11);
            int reward = mathMark * 10 + physicalEducationMark * 5 + biologyMark * 7;
            group2[i] = new Student(id, name, age, group, mathMark, physicalEducationMark, biologyMark, reward);
        }

        Student[] group3 = new Student[5];
        for (int i = 0; i < group3.Length; i++)
        {
            int id = i + 11;
            string name = "Student " + id;
            int age = random.Next(18, 25);
            string group = "Group3";
            int mathMark = random.Next(1, 11);
            int physicalEducationMark = random.Next(1, 11);
            int biologyMark = random.Next(1, 11);
            int reward = mathMark * 10 + physicalEducationMark * 5 + biologyMark * 7;
            group3[i] = new Student(id, name, age, group, mathMark, physicalEducationMark, biologyMark, reward);
        }
        Student[] Group1 = Student.GenerateStudents();

        // Print out the details of all students in each group
        Console.WriteLine("Group1: ");
        foreach (var student in group1)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        Console.WriteLine("Group2: ");
        foreach (var student in group2)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        Console.WriteLine("Group3: ");
        foreach (var student in group3)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
        List<Student[]> groupList = new List<Student[]>
        {
            group1,
            group2,
            group3
        };


        Student.PrintBestMathStudents(group1);
        Student.PrintBestMathStudents(group2);
        Student.PrintBestMathStudents(group3);

        Student.PrintBestPhysicalEducationStudents(group1);
        Student.PrintBestPhysicalEducationStudents(group2);
        Student.PrintBestPhysicalEducationStudents(group3);

        Student.PrintBestBiologyStudents(group1);
        Student.PrintBestBiologyStudents(group2);
        Student.PrintBestBiologyStudents(group3);

        /*foreach ()
        {
            student1.SetReward(random.Next(0, 100));
        }*/
    }
}