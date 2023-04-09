using System.Data.SqlTypes;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testing();
            //TMSlesson();
            //ABC();
            GoodDay();

        }

        /// <summary>
        /// Задать строку содержащую внутри цифры и несколько повторений слова test,
        /// Заменить в строке все вхождения 'test' на 'testing'.
        /// </summary>

        public static void Testing()
        {
            string set = " 1, 5, 6, test, test, 32, 56, test ";
            Console.WriteLine(set);

            set = set.Replace("test", "testing");
            Console.WriteLine(set);
        }

        /// <summary>
        /// Создайте переменные, которые будут хранить следующие слова:
        /// (Welcome, to, the, TMS, lessons)выполните конкатенацию слов
        /// и выведите на экран следующую фразу: Welcome to the TMS lessons.
        /// Каждое слово должно быть записано отдельно и взято в кавычки,
        /// например "Welcome". Не забывайте о пробелах после каждого слова
        /// </summary>

        public static void TMSlesson()
        {
            string n1 = "Welcome";
            string n2 = "to";
            string n3 = "the";
            string n4 = "TMS";
            string n5 = "lessons";
            string[] values = new string[] { n1, n2, n3, n4, n5 };

            string n = "\"" + string.Join("\" \"", values) + "\"";
            Console.WriteLine(n);
        }

        /// <summary>
        /// Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        /// Необходимо найти в данной строке "abc", записав всё что до этих символов
        /// в переменную firstPart, а также всё, что после них во вторую secondPart.
        /// Результат вывести в консоль.
        /// </summary>

        public static void ABC()
        {
            string input = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string pattern = "abc";
            Console.WriteLine($"Input: {input}");

            int foundPattern = input.IndexOf(pattern);
            string firstPart = input.Substring(0, foundPattern);
            string secondPart = input.Substring(foundPattern + pattern.Length);

            Console.WriteLine($"First part: {firstPart}");
            Console.WriteLine($"Second part: {secondPart}");
        }



        /// <summary>
        ///  Дана строка: Good day 
        /// Необходимо с помощью метода substring удалить слово "Good".
        /// После чего необходимо используя команду insert создать строку со значением: The best day!!!!!!!!!.
        ///Заменить последний "!" на "?" и вывести результат на консоль.
        /// </summary>
        public static void GoodDay()
        {
            string input = "Good day";
            Console.WriteLine($"Input: {input}");

            string pattern = "Good";
            int foundPattern = input.IndexOf(pattern);
            string input1 = input.Substring(foundPattern + pattern.Length);
            Console.WriteLine($"Input: {input1}");

            string input2 = input1.Insert(0, "The best");
            string input3 = input2.Insert(input2.Length, "!!!!!!!!!");
            Console.WriteLine(input3);

            input3 = input3.Substring(0, input3.Length - 1) + "?";
            Console.WriteLine(input3);

        }

    }
}