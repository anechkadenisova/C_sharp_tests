using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    internal class Restaurant
    {
        public Employee[] allEmloyees;

        public List<Happening> RestaurantsHappenings { get; }

        public Restaurant()
        {
            Cook RestaurantsCook = new Cook("Ivan");
            Cleaner RestaurantsCLeaner = new Cleaner("Andrey");
            Manager RestaurantsManager = new Manager("Nikita");
            allEmloyees = new Employee[3] { RestaurantsCLeaner, RestaurantsManager, RestaurantsCook };
            RestaurantsHappenings = GenerateHappenings();
        }

        public void RestaurantWork()
        {
            if (RestaurantsHappenings.Count == 0)
            {
                Console.WriteLine("All happenings have been worked out");
                return;
            }

            foreach (Happening happening in RestaurantsHappenings) 
            {
                WorkOutHappening(happening);
            }

            RestaurantsHappenings.Clear();
        }

        void WorkOutHappening(Happening happening)
        {
            switch (happening) 
            {
                case Happening.CustomerOrder:
                    ICookable emplyeeAbleToCook = (ICookable)SelectEmployeeAbleForWork(happening);
                    emplyeeAbleToCook.CookFood();
                    break;
                case Happening.RestaurantIsDirty:
                    ICleanable emplyeeAbleToClean = (ICleanable)SelectEmployeeAbleForWork(happening);
                    emplyeeAbleToClean.Clean();
                    break;
                case Happening.Conflicts:
                    IConflictSolveable emplyeeAbleToSolveConflict = (IConflictSolveable)SelectEmployeeAbleForWork(happening);
                    emplyeeAbleToSolveConflict.SolveConflict();
                    break;
                case Happening.ManagmentIsNeeded:
                    IManageable emplyeeAbleToManage = (IManageable)SelectEmployeeAbleForWork(happening);
                    emplyeeAbleToManage.Manage();
                    break;
            }
        }
        public Employee SelectEmployeeAbleForWork(Happening happening)
        {
            Random random = new Random();
            int anyAbleEmployeeIndex = random.Next(0, allEmloyees.Length);

            while (!CheckIfAble(allEmloyees[anyAbleEmployeeIndex], happening))
            {
                anyAbleEmployeeIndex = random.Next(0, allEmloyees.Length);
            }

            return allEmloyees[anyAbleEmployeeIndex];

        }

        public static bool CheckIfAble(Employee employee, Happening happening)
        {
            switch (happening)
            {
                case Happening.CustomerOrder:
                    return (employee is ICookable);
                case Happening.RestaurantIsDirty:
                    return (employee is ICleanable);
                case Happening.Conflicts:
                    return (employee is IConflictSolveable);
                case Happening.ManagmentIsNeeded:
                    return (employee is IManageable);
            }
            return false;
        }

        public List<Happening> GenerateHappenings()
        {
            Random rand = new Random();
            List<Happening> randomHappenings = new List<Happening>(rand.Next(1, 10));

            for (int i = 0; i < randomHappenings.Capacity;  i++)
            {
                randomHappenings.Add((Happening)rand.Next(0, 3));
            }
            return randomHappenings;    
        }
    }
}
