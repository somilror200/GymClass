using System;

namespace GymClass
{
    class GymSystem
    {
        static void Main(string[] args)
        {
            Gym SomilGym = new Gym();
            do
            {
                Console.Clear();
                Console.WriteLine(" WELCOME TO SOMIL GYM");
                SomilGym.DrawTable();
                Console.WriteLine("1. Add a Member");
                Console.WriteLine("2. Increase Pack Validity of a member");
                Console.WriteLine("3. Delete a member");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.WriteLine("Choose your option");
                Console.Write(">> ");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    SomilGym.AddMember();
                }
                else if (option == 2)
                {
                    SomilGym.IncreasePackValidity();
                }
                else if (option == 3)
                {
                    SomilGym.DeleteMember();
                }
                else if (option == 4)
                {
                    break;
                }
            }
            while (true);
            Console.WriteLine("Good Bye!! See you soon");
        }
    }
}
